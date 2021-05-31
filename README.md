# F# Azure Functions example for Dotnet 5 isolated

This repository is an example how to write Azure functions in F# using Dotnet 5 in isolated mode. In the original project template there is an issue that the *.fsproj file uses `Update` directive for `host.json` and `local.settings.json` instead of `Include`

Old one:
```
<ItemGroup>
    <None Update="host.json">
        <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Update="local.settings.json">
        <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
        <CopyToPublishDirectory>Never</CopyToPublishDirectory>
    </None>
    <Content Include="README.md" />
</ItemGroup>
```

Fixed version:
```
<ItemGroup>
    <None Include="host.json">
        <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Include="local.settings.json">
        <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
        <CopyToPublishDirectory>Never</CopyToPublishDirectory>
    </None>
    <Content Include="README.md" />
</ItemGroup>

```
