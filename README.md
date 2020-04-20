# Chartist.Blazor
A Blazor implementation of ChartistJS

![ci-build](https://github.com/sxotney/Chartist.Blazor/workflows/ci-build/badge.svg)

Influenced by mariusmuntean's [ChartJS.Blazor](https://github.com/mariusmuntean/ChartJs.Blazor) and [Steve Sanderson's demo](https://github.com/SteveSandersonMS/presentation-2020-01-NdcBlazorComponentLibraries) and of course [ChartistJS itself](https://github.com/gionkunz/chartist-js)

## Demo

[Demo here](https://chartistblazordemo.azurewebsites.net/)

## Installation

To Install 

```ps1
Install-Package Chartist.Blazor
```
or
```
dotnet add package Chartist.Blazor
```

For client-side and server-side Blazor - add script section to index.html or _Host.cshtml (head section)

```xml
    <link href="_content/Chartist.Blazor/chartist.min.css" rel="stylesheet" />
    <script src="_content/Chartist.Blazor/chartist.min.js"></script>
    <script src="_content/Chartist.Blazor/blazorChartistInterop.js"></script>
```


## Release Notes

### What's New

- This library allows you to add line, bar and pie chart components to your Blazor apps

### Gotchas

- Due to serialisation configuration missing from the current release of Blazor (3.2), some chart options are not available and will be set to whatever the default value in the JS library is

### Bug Fixes

- None for this initial release
