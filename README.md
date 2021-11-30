# UnlockedData.Chartist.Blazor

A Blazor implementation of ChartistJS

[![ci-build](https://github.com/UnlockedData/UnlockedData.Chartist.Blazor/actions/workflows/ci-build.yml/badge.svg)](https://github.com/UnlockedData/UnlockedData.Chartist.Blazor/actions/workflows/ci-build.yml)

A Blazor implementation of [ChartistJS](https://github.com/gionkunz/chartist-js) strongly influenced by [Steve Sanderson's NDC demo](https://github.com/SteveSandersonMS/presentation-2020-01-NdcBlazorComponentLibraries) 

## Installation

To Install:

```ps1
Install-Package UnlockedData.Chartist.Blazor
```

or

```ps1
dotnet add package UnlockedData.Chartist.Blazor
```

For client-side and server-side Blazor - add script section to index.html or _Layout.cshtml (head section)

```xml
    <link href="_content/UnlockedData.Chartist.Blazor/chartist.min.css" rel="stylesheet" />
    <script src="_content/UnlockedData.Chartist.Blazor/chartist.min.js"></script>
    <script src="_content/UnlockedData.Chartist.Blazor/blazorChartistInterop.min.js"></script>
```

## Release Notes

### What's New

- New options have been enabled as JSON serializer options allow for ignoring null values
- Line smoothing is now controllable using the bundled interpolation functions (as is axis labelling) 
- Some plugins have been bundled. Legends, tooltips and point labels can be enabled on the charts by setting the relevant options flags


### Known Issues

- None for this release

### Bug Fixes

- None for this release
