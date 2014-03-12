#  Based on :
# https://github.com/DefinitelyTyped/NugetAutomation/blob/master/CreatePackages.ps1
# https://github.com/peters/myget/blob/master/myget.include.ps1

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
        [string]$outputFolder,

        [parameter(Position = 4, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$config 

    )
		
    if(-not (Test-Path $project)) {
        Die "Could not find project: $project"
    }

	$rootFolder = Normalize-Path $rootFolder
	$nugetExe = NugetExe-Path

	$buildFolder = Join-Path (Join-Path $rootFolder "bin") $config
	
	$projectName = [System.IO.Path]::GetFileName($project) -ireplace ".(sln|csproj)$", ""
	Write-Diagnostic "Nupkg: $projectName ($config)"

	. $nugetExe pack $project -Build -OutputDirectory $outputFolder -NonInteractive `
            -Version $version -Properties Configuration=$config
    
    if($LASTEXITCODE -ne 0) {
        Die "Build failed: $projectName" -exitCode $LASTEXITCODE
    }
}

function Push-Nupkg {
	param(
        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$nupkg,
		[parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$nugetApiKey,
		[parameter(Position = 2, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$source
    )

	$nugetExe = NugetExe-Path
	.  $nugetExe push $nupkg -ApiKey $nugetApiKey -Source $source -NonInteractive
}

function Packages-Clean {
	param(
        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
	    [string]$rootFolder
    )

    Write-Diagnostic "Packages: Clean"

	$binFolder = Join-Path $rootFolder "bin"

	Get-ChildItem $binFolder | 
		Where-Object { $_.FullName -match ".nupkg$" } |
		select -expand FullName |
		sort Length -Descending | 
		ForEach-Object {
			try{
				Remove-Item $_ -Force -Recurse
			}
			catch{}
		}
}
