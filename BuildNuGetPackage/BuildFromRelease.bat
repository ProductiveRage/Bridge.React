@echo off

%~d0
cd "%~p0"

del *.nu*
del *.dll
del *.pdb
del *.xml
del *.ps1

copy ..\Bridge.React\bin\Release\Bridge.React.dll > nul
copy ..\Bridge.React\bin\Release\Bridge.React.xml > nul

copy ..\Bridge.React.Analyser\Analyser\bin\Release\*.dll > nul
copy ..\Bridge.React.Analyser\Analyser\bin\Release\tools\* > nul

copy ..\Bridge.React.nuspec > nul
..\packages\NuGet.CommandLine.2.8.5\tools\nuget pack -NoPackageAnalysis Bridge.React.nuspec