# UnlockedData.Chartist.Blazor

A Blazor implementation of ChartistJS

![ci-build](https://github.com/sxotney/Chartist.Blazor/workflows/ci-build/badge.svg)

Influenced by mariusmuntean's [ChartJS.Blazor](https://github.com/mariusmuntean/ChartJs.Blazor) and [Steve Sanderson's demo](https://github.com/SteveSandersonMS/presentation-2020-01-NdcBlazorComponentLibraries) and of course [ChartistJS itself](https://github.com/gionkunz/chartist-js)

## Demo

[Demo here](https://chartistblazordemo.azurewebsites.net/)

## Installation

To Install:

```ps1
Install-Package Chartist.Blazor
```

or

```ps1
dotnet add package Chartist.Blazor
```

For client-side and server-side Blazor - add script section to index.html or _Host.cshtml (head section)

```xml
    <link href="_content/UnlockedData.Chartist.Blazor/chartist.min.css" rel="stylesheet" />
    <script src="_content/UnlockedData.Chartist.Blazor/chartist.js"></script>
    <script src="_content/UnlockedData.Chartist.Blazor/blazorChartistInterop.js"></script>
```

## Release Notes

### What's New

- Namespaces have been changed for this release
- Event callbacks can now be passed to chart points
- Components have been made more 'Blazory' with series and points now usable as components within a chart
- Series data objects have been updated to reflect the core Chartist JS type, extension methods have been added to maintain backwards compatibility

### Known Issues

- Due to serialisation configuration missing from the current release of Blazor (3.2), some chart options are not available and will be set to whatever the default value in the JS library is. These will be available to set to empty in a future release as looking at the Chartist source, defaults get set when these are missing.
- A small change has been made to the chartist js source as it is way easier to select items in query selector that don't have colons in them.

### Bug Fixes

- None for this release
