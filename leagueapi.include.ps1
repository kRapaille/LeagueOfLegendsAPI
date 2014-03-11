# Source : https://github.com/DefinitelyTyped/NugetAutomation/blob/master/CreatePackages.ps1

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

function Get-Project-Folder {
	param(
		[parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
		[string]$rootFolder,
		[parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
		[string]$project
	)

	$projectPath = [System.IO.Path]::Combine($rootFolder, $project)
	$projectFolder = [System.IO.Path]::GetDirectoryName($projectPath)

	return $projectFolder 
}

function Get-Assembly-Version {
	param(
			[parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
			[string]$projectFolder
		)

	$assemblyPattern = "[0-9]+(\.([0-9]+|\*)){1,3}"  
	$assemblyVersionPattern = 'AssemblyVersion\("([0-9]+(\.([0-9]+|\*)){1,3})"\)'  
      
	$foundFiles = get-childitem $projectFolder\Properties\*AssemblyInfo.cs -recurse  

	$rawVersionNumberGroup = get-content $foundFiles | select-string -pattern $assemblyVersionPattern | select -first 1 | % { $_.Matches }    
	          
	return $rawVersionNumberGroup.Groups[1].Value 
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

## MYGET

. $rootFolder\myget.include.ps1

function League-Build-Project {
    param(
        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$rootFolder,

        [parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$outputFolder,

        [parameter(Position = 2, Mandatory = $true, ValueFromPipeline = $true)]
        [ValidatePattern(".(sln|csproj)$")]
        [string]$project,

        [parameter(Position = 3, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$config,

        [parameter(Position = 4, Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateSet("rebuild", "build")]
        [string]$target,
        
        [parameter(Position = 6, Mandatory = $false, ValueFromPipeline = $true)]
        [ValidateSet("v1.1", "v2.0", "v3.5", "v4.0", "v4.5", "v4.5.1", ".NETPortable0.0-net45+wp8+win8")]
        [string[]]$targetFrameworks = @(),

        [parameter(Position = 7, Mandatory = $false, ValueFromPipeline = $true)]
        [ValidateSet("v1.1", "v2.0", "v3.5", "v4.0", "v4.5", "v4.5.1")]
        [string]$targetFramework = $null,

        [parameter(Position = 8, Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateSet("x86", "x64", "AnyCpu")]
        [string]$platform,

        [parameter(Position = 9, Mandatory = $true, ValueFromPipeline = $true)]
        [ValidateSet("Quiet", "Minimal", "Normal", "Detailed", "Diagnostic")]
        [string]$verbosity = "Minimal",

        [parameter(Position = 10, ValueFromPipeline = $true)]
        [string]$MSBuildCustomProperties = $null
    )
	
    $projectPath = [System.IO.Path]::Combine($rootFolder, $project)
    $projectName = [System.IO.Path]::GetFileName($projectPath) -ireplace ".(sln|csproj)$", ""
	$projectOutputPath = Join-Path $outputFolder "$config\$projectName"

    MyGet-Create-Folder $outputFolder

    if(-Not (Test-Path $projectPath)) {
        MyGet-Die "Could not find project: $projectPath"
    }

    League-Build-Bootstrap $projectPath

    if($targetFrameworks.Length -eq 0) {
        $targetFrameworks += $targetFramework
    }

    if($targetFrameworks.Length -eq 0) {
        MyGet-Die "Please provide a targetframework to build project for."
    }

    $targetFrameworks | ForEach-Object {
        
        $targetFramework = $_

        MyGet-Create-Folder $projectOutputPath

        MyGet-Write-Diagnostic "Build: $projectName ($platform / $config - $targetFramework)"

        # By default copy build output to final output path
        $msbuildOutputFilename = Join-Path $projectOutputPath "msbuild.log"
        switch -Exact (MyGet-BuildRunner) {
            "myget" {
                
                # Otherwise copy to root folder so that we can see the
                # actual build failure in MyGet web interface
                $msbuildOutputFilename = Join-Path $rootFolder "msbuild.log"

            }
        }

        # YOLO
        $msbuildPlatform = $platform
        if($msbuildPlatform -eq "AnyCpu") {
            $msbuildPlatform = "Any CPU"
        }

        # http://msdn.microsoft.com/en-us/library/vstudio/ms164311.aspx
        & "$(Get-Content env:windir)\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" `
            $projectPath `
            /target:$target `
            /property:Configuration=$config `
            /property:OutputPath=$projectOutputPath `
            /property:TargetFrameworkVersion=$targetFramework `
            /property:Platform=$msbuildPlatform `
            /maxcpucount `
            /verbosity:$verbosity `
            /fileLogger `
            /fileLoggerParameters:LogFile=$msbuildOutputFilename `
            /nodeReuse:false `
            /nologo `
            $MSBuildCustomProperties `
        
        if($LASTEXITCODE -ne 0) {
            MyGet-Die "Build failed: $projectName ($Config - $targetFramework)" -exitCode $LASTEXITCODE
        }

    }
}

function League-Build-Bootstrap {
    param(
        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$project
    )

    MyGet-Write-Diagnostic "Build: Bootstrap"

    $solutionFolder = (Get-Item ([System.IO.Path]::GetDirectoryName($project))).parent
    $nugetExe = MyGet-NugetExe-Path

    . $nugetExe config -Set Verbosity=quiet

    if($project -match ".sln$") {
        . $nugetExe restore $project -NonInteractive
    }

    MyGet-Grep -folder $solutionFolder -recursive $true -pattern ".packages.config$" | ForEach-Object {
        . $nugetExe restore $_.FullName -NonInteractive -SolutionDirectory $solutionFolder
    }
}

function League-Build-Nupkg {
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
        MyGet-Die "Could not find project: $project"
    }

	$rootFolder = MyGet-Normalize-Path $rootFolder
	$nugetExe = MyGet-NugetExe-Path

	$projectName = [System.IO.Path]::GetFileName($project) -ireplace ".(sln|csproj)$", ""
	MyGet-Write-Diagnostic "Nupkg: $projectName ($platform / $config)"

	if($nugetIncludeSymbols -eq $true) {
        . $nugetExe pack $project -OutputDirectory $outputFolder -Symbols  -NonInteractive `
            -Version $version
    } else {
        . $nugetExe pack $project -OutputDirectory $outputFolder -NonInteractive `
			-Version $version
    }
    
    if($LASTEXITCODE -ne 0) {
        MyGet-Die "Build failed: $projectName" -exitCode $LASTEXITCODE
    }

	# Support multiple build runners
    switch -Exact (MyGet-BuildRunner) {
        "myget" {
                
			Write-Host $rootFolder

            $mygetBuildFolder = Join-Path $rootFolder "Build"

            MyGet-Create-Folder $mygetBuildFolder

            MyGet-Grep $outputFolder -recursive $false -pattern ".nupkg$" | ForEach-Object {
                $filename = $_.Name
                $fullpath = $_.FullName
		
		        cp $fullpath $mygetBuildFolder\$filename
            }
        }
    }
}