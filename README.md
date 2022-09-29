# UnlockedData.Chartist.Blazor

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

- Override the options for individual line and bar chart series.
- Class names can now be applied to series, allowing targeting of CSS. There is a helper function object that allows html classes to be applied to specific created elements. See the example for both in action with a show of CSS animation 

### Known Issues

- Major refactor with some possible API changes. 
- InterpolationType is now enum as opposed to string

### Bug Fixes

- None for this release
