param(
    [string[]]$projects = @(
        "LeagueAPI.PCL.Test\PortableLeagueAPI.Test.csproj",
        "PortableLeagueApi.Interfaces\PortableLeagueApi.Interfaces.csproj",
        "PortableLeagueApi.Core\PortableLeagueApi.Core.csproj",
        "PortableLeagueAPI.Champion\PortableLeagueApi.Champion.csproj",
        "PortableLeagueApi.Game\PortableLeagueApi.Game.csproj",
        "PortableLeagueApi.League\PortableLeagueApi.League.csproj",
        "PortableLeagueApi.Static\PortableLeagueApi.Static.csproj",
        "PortableLeagueApi.Stats\PortableLeagueApi.Stats.csproj",
        "PortableLeagueApi.Summoner\PortableLeagueApi.Summoner.csproj",
        "PortableLeagueApi.Team\PortableLeagueApi.Team.csproj",
		"LeagueAPI.PCL\PortableLeagueAPI.csproj"
    ),
    [string[]]$platforms = @(
        "AnyCpu"
    ),
    [string[]]$targetFrameworks = @(
        "v4.5"
    ),
    [string]$config = "Release",
    [string]$target = "Rebuild",
    [string]$verbosity = "Minimal",
    [bool]$clean = $true,
	[bool]$unittests = $true
)

# Initialization
$rootFolder = Split-Path -parent $script:MyInvocation.MyCommand.Path

. $rootFolder\leagueapi.include.ps1

# Solution
$solutionName = "PortableLeagueAPI"
$solutionFolder = Join-Path $rootFolder "$solutionName"
$outputFolder = Join-Path $rootFolder "bin"

# Do not build a .nupkg for these projects
$excludeNupkgProjects = @(
    $projects[0]
)

# Clean
if($clean) { MyGet-Build-Clean $rootFolder }

$newPackagesVersions = @{}

# Platforms to build for
$platforms | ForEach-Object {
    $platform = $_

    # Projects to build
    $projects | ForEach-Object {
       
        $project = $_
		
        # Build project
        League-Build-Project -rootFolder $rootFolder `
            -outputFolder $outputFolder `
            -project $project `
            -config $config `
            -target $target `
            -targetFrameworks $targetFrameworks `
            -platform $platform `
            -verbosity $verbosity
		        
		# Build .nupkg if project is not excluded and needed
        if(-not ($excludeNupkgProjects -contains $project)) {

			$projectFolder = Get-Project-Folder -rootFolder $rootFolder `
				-project $project

			$packageId = Get-Package-Id -rootFolder $rootFolder `
				-project $project

			$nuSpecFromNuget = Get-MostRecentNugetSpec -nugetPackageId $packageId
			
			$version = Get-Last-NuGet-Version -spec $nuSpecFromNuget
						
			$assemblyVersion = Get-Assembly-Version -projectFolder $projectFolder

			$isNewVersion = $false

			if($assemblyVersion -ne $version) {
				$version = $assemblyVersion
				$isNewVersion = $true
			}

			$newPackagesVersions.Add($packageId, $version)

			Update-Nuspec -rootFolder $rootFolder `
				-project $project `
				-newPackagesVersions $newPackagesVersions
			
			if($isNewVersion){

				League-Build-Nupkg -rootFolder $rootFolder `
					-outputFolder $outputFolder `
					-project $project `
					-version $version
			}
        }
		else {

			if($unittests) {

				$buildFolder = Join-Path $outputFolder $config

				MyGet-TestRunner-Nunit -rootFolder $rootFolder `
					-buildFolder $buildFolder `
					-filter "Test.dll$"
			}
		}
    }
}