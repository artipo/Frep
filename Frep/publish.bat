dotnet publish --self-contained true -r win-x64 -c Release -p:PublishTrimmed=True -P:TrimMode=CopyUsed -p:PublishSingleFile=True -p:SatelliteResourceLanguages=en .\Frep.fsproj
