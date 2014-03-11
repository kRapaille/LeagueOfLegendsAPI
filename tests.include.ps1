. $rootFolder\tools.include.ps1

function NunitExe-Path {
    param(
        [ValidateSet("2.6.2", "2.6.3", "latest")]
        [string] $version = "latest"
    )

    $nunit = Join-Path $buildRunnerToolsFolder "tools\nunit\$version\nunit-console.exe"
    if (Test-Path $nunit) {
        return $nunit
    }

	Die "Could not find nunit executable: $nunit"
}

function TestRunner-Nunit {
    # documentation: http://www.nunit.org/index.php?p=consoleCommandLine&r=2.6.3

    param(
        [parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$rootFolder,
        [parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$buildFolder,
        [parameter(Position = 2, Mandatory = $false, ValueFromPipeline = $true)]
        [string]$options = "/nologo",
        [parameter(Position = 3, Mandatory = $false, ValueFromPipeline = $true)]
        [string]$minTargetFramework = "v2.0",
        [parameter(Position = 4, Mandatory = $false, ValueFromPipeline = $true)]
        [string]$version = "latest",
        [parameter(Position = 5, Mandatory = $false, ValueFromPipeline = $true)]
        [int16]$timeoutDuration = $([int16]::MaxValue)
    )

    $nunitExe = NunitExe-Path
    $nunitExeX86 = Join-Path (Split-Path -Parent $nunitExe) "nunit-console-x86.exe"
	
    $net45 = @()

    # Find all test libraries based on specified filter
    Get-ChildItem $buildFolder -Recurse | Where-Object { $_.FullName -match "Test.dll$" } | ForEach-Object {
        $fullPath = $_.FullName
        $assemblyInfo = AssemblyInfo $fullPath
        # Only accept managed libraries
        if($assemblyInfo.ModuleAttributes -contains "ILOnly") {
            $targetFramework = $assemblyInfo.TargetFramework.Substring(3)
            if (-not ($targetFramework -ge "45")) {
                return
            }
            
            $net45 += $fullPath
			     
        } else {
            Write-Output "Skipped test library $fullPath because it's not .NET assembly"
        }
	} 

    function TestSuite($nunit, $arguments) {
        
        $process = Start-Process -PassThru -NoNewWindow $nunit ($arguments | %{ "`"$_`"" })
        Wait-Process -InputObject $process -Timeout $timeoutDuration

        $exitCode = $process.ExitCode
        if($exitCode -ne 0) {
            Die "Test suite failed" -exitCode $exitCode
        }

    }

    $arguments = @()
    $net45 | ForEach-Object { $arguments += $_ }

    $numProjects = $arguments.Length

    Write-Diagnostic "nunit-console.exe: Running tests for $numProjects projects."   

    Write-Output ""
    Write-Output $arguments | Sort-Object -Property FullName
    Write-Output ""

    $xml = Join-Path $buildFolder "nunit-result.xml"
    $arguments += ($options -split " ")
    $arguments += "/framework=net-4.5"
    $arguments += "/xml=$xml"

    TestSuite -nunit $nunitExe -arguments $arguments
}