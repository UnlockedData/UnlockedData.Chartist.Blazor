using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace UnlockedData.Chartist.Blazor.Core;

public abstract class ChartBase : ComponentBase
{
    protected ElementReference elem;

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> ExtraAttributes { get; set; }

    [Parameter] public bool RotateHorizontalLabels { get; set; } = false;

    [Parameter] public EventCallback<ChartistMouseEventArgs> OnDataPointClicked { get; set; }

    [Parameter] public EventCallback<ChartistMouseEventArgs> OnDataPointEntered { get; set; }

    [Parameter] public EventCallback<ChartistMouseEventArgs> OnDataPointExited { get; set; }

    [JSInvokable]
    public virtual async Task JSDomDataPointClicked(ChartistMouseEventArgs args)
    {
        await OnDataPointClicked.InvokeAsync(args);
    }

    [JSInvokable]
    public virtual async Task JSDomDataPointEntered(ChartistMouseEventArgs args)
    {
        await OnDataPointEntered.InvokeAsync(args);
    }

    [JSInvokable]
    public virtual async Task JSDomDataPointExited(ChartistMouseEventArgs args)
    {
        await OnDataPointExited.InvokeAsync(args);
    }

    protected virtual string ClassForRotatedHorizontalLabels()
    {
        return RotateHorizontalLabels ? "rotate-horizontal-labels" : string.Empty;
    }
}
