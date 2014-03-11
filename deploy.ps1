param(
	#[string]$apikey = "1d731ba5-5e85-4289-8250-33c686b497ef",
	#[string]$source = "https://www.nuget.org"
	[string]$apikey = "b2274d59-b337-4f72-aee2-7ead96d2d208",
	[string]$source = "https://staging.nuget.org"
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