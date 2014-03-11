#  Based on :
# https://github.com/DefinitelyTyped/NugetAutomation/blob/master/CreatePackages.ps1
# https://github.com/peters/myget/blob/master/myget.include.ps1

. $rootFolder\tools.include.ps1

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

function Build-Project {
    param(
        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$rootFolder,

        [parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$outputFolder,

        [parameter(Position = 2, Mandatory = $true, ValueFromPipeline = $true)]
        [ValidatePattern(".(sln|csproj)$")]
        [string]$project,

        [parameter(Position = 3, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$config
    )
		
    $projectPath = [System.IO.Path]::Combine($rootFolder, $project)
    $projectName = [System.IO.Path]::GetFileName($projectPath) -ireplace ".(sln|csproj)$", ""
	$projectOutputPath = Join-Path $outputFolder "$config\$projectName"

    Create-Folder $outputFolder

    if(-Not (Test-Path $projectPath)) {
        Die "Could not find project: $projectPath"
    }

    Build-Bootstrap $projectPath

	Create-Folder $projectOutputPath
				
    $msbuildPlatform = "Any CPU"

    Write-Diagnostic "Build: $projectName ($msbuildPlatform / $config - v4.5)"

    # By default copy build output to final output path
    $msbuildOutputFilename = Join-Path $projectOutputPath "msbuild.log"

    # http://msdn.microsoft.com/en-us/library/vstudio/ms164311.aspx
    & "$(Get-Content env:windir)\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" `
        $projectPath `
        /target:rebuild `
        /property:Configuration=$config `
        /property:OutputPath=$projectOutputPath `
        /property:TargetFrameworkVersion=v4.5 `
        /property:Platform=$msbuildPlatform `
        /maxcpucount `
        /verbosity:Minimal `
        /fileLogger `
        /fileLoggerParameters:LogFile=$msbuildOutputFilename `
        /nodeReuse:false `
        /nologo
        
    if($LASTEXITCODE -ne 0) {
        Die "Build failed: $projectName ($Config - v4.5)" -exitCode $LASTEXITCODE
    }
}

function Build-Clean {
	param(
        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
	    [string]$rootFolder
    )

    Write-Diagnostic "Build: Clean"

	$binFolder = Join-Path $rootFolder "bin"

	Get-ChildItem $binFolder |
			select -expand FullName |
			sort Length -Descending | 
			ForEach-Object {
				try{
					Remove-Item $_ -Force -Recurse
				}
				catch{}
			}
}

function Build-Bootstrap {
    param(
        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$project
    )

    Write-Diagnostic "Build: Bootstrap"

    $solutionFolder = (Get-Item ([System.IO.Path]::GetDirectoryName($project))).parent
    $nugetExe = NugetExe-Path

    . $nugetExe config -Set Verbosity=quiet

    if($project -match ".sln$") {
        . $nugetExe restore $project -NonInteractive
    }

    Grep -folder $solutionFolder -recursive $true -pattern ".packages.config$" | ForEach-Object {
        . $nugetExe restore $_.FullName -NonInteractive -SolutionDirectory $solutionFolder
    }
}