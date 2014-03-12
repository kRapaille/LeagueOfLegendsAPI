param(
	[string]$apikey,
	[string]$source
)

# Initialization
$rootFolder = Split-Path -parent $script:MyInvocation.MyCommand.Path
$buildFolder = Join-Path $rootFolder "bin"

. $rootFolder\pack.ps1 -unittests 0

Get-ChildItem $buildFolder | Where-Object { $_.FullName -match ".nupkg$" } | ForEach-Object {
    $fullPath = $_.FullName

	Push-Nupkg -nupkg $fullPath `
				-nugetApiKey $apikey `
				-source $source
}