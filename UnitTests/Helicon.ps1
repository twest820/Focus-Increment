$unitTestPath = [System.IO.Path]::Combine([System.Environment]::GetFolderPath([System.Environment+SpecialFolder]::MyDocuments), "photography\FocusIncrement\UnitTests")
cd $unitTestPath
$testResults = Get-ChildItem -Path ([System.IO.Path]::Combine($unitTestPath, "..", "TestResults")) -Directory -Filter "Deploy*"
$stackDirectory = [System.IO.Path]::Combine($testResults[0].FullName, "Out")

Import-Module -Name ".\bin\Debug\FocusIncrement.dll"
Convert-Helicon -StackDirectory $stackDirectory;

Get-Alignment -Project ([System.IO.Path]::Combine($stackDirectory, "P1070712.zsj"));
Get-Alignment -Project ([System.IO.Path]::Combine($stackDirectory, "P1070726B.hproj"));
Get-Alignment -Project ([System.IO.Path]::Combine($stackDirectory, "P1070726C.hproj"));
