. $rootFolder\tools.include.ps1

function Get-MostRecentNugetSpec {
	param(
		[parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
		[string]$nugetPackageId
	)

    $feeedUrl= "http://packages.nuget.org/v1/FeedService.svc/Packages()?`$filter=Id%20eq%20'$nugetPackageId'&`$orderby=Version%20desc&`$top=1"
    $webClient = new-object System.Net.WebClient
    $feedResults = [xml]($webClient.DownloadString($feeedUrl))
    return $feedResults.feed.entry
}

function Get-Last-NuGet-Version {
	param(
		[parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
		[System.Xml.XmlElement] $spec
	)
	
    $v = $spec.properties.version."#text"
    if(!$v) {
        $v = $spec.properties.version
    }
    return [string]$v
}

function Get-Package-Id{
	param(
		[parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
		[string]$rootFolder,
		[parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
		[string]$project
	)

	$nuspecPath = [System.IO.Path]::Combine($rootFolder, $project) -ireplace ".(sln|csproj)$", ".nuspec"
	[xml] $nuSpec = Get-Content -Path $nuspecPath

	return $nuSpec.package.metadata.id;
}

function Update-Nuspec {
	param(
		[parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
		[string]$rootFolder,
		[parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
		[string]$project,
		[parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
		$newPackagesVersions
	)

	$nuspecPath = [System.IO.Path]::Combine($rootFolder, $project) -ireplace ".(sln|csproj)$", ".nuspec"
	[xml] $nuSpec = Get-Content $nuspecPath -Encoding utf8

	$depedencies = $nuSpec.package.metadata.dependencies.group.dependency
		
	if($depedencies.Count -gt 0)
	{
		$depedencies | ForEach-Object {
       		$depedency = $_
			
			if($newPackagesVersions.ContainsKey($depedency.id))
			{
				$newVersion = $newPackagesVersions.Get_Item($depedency.id);
				$depedency.version = $newVersion
			}
		}
		
		$nuSpec.Save($nuspecPath)
	}
}

function Build-Nupkg {
	param(

        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [ValidatePattern(".(sln|csproj)$")]
        [string]$project,
        
        [parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
        [ValidatePattern("^([0-9]+)\.([0-9]+)\.([0-9]+)(?:-([0-9A-Za-z-]+(?:\.[0-9A-Za-z-]+)*))?(?:\+[0-9A-Za-z-]+)?$")]
        [string]$version,

        [parameter(Position = 2, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$rootFolder,

        [parameter(Position = 3, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$outputFolder

    )
		
    if(-not (Test-Path $project)) {
        Die "Could not find project: $project"
    }

	$rootFolder = Normalize-Path $rootFolder
	$nugetExe = NugetExe-Path

	$projectName = [System.IO.Path]::GetFileName($project) -ireplace ".(sln|csproj)$", ""
	Write-Diagnostic "Nupkg: $projectName ($platform / $config)"

	. $nugetExe pack $project -OutputDirectory $outputFolder -Symbols  -NonInteractive `
            -Version $version
    
    if($LASTEXITCODE -ne 0) {
        Die "Build failed: $projectName" -exitCode $LASTEXITCODE
    }
}