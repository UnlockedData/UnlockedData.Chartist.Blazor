using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace UnlockedData.Chartist.Blazor.Core;

public abstract class ChartBase : ComponentBase
{
    [Inject]
    public IJSRuntime JS { get; set; }
    
    [Parameter] public bool RotateHorizontalLabels { get; set; } 

    [Parameter] public EventCallback<ChartistMouseEventArgs> OnDataPointClicked { get; set; }

    [Parameter] public EventCallback<ChartistMouseEventArgs> OnDataPointEntered { get; set; }

    [Parameter] public EventCallback<ChartistMouseEventArgs> OnDataPointExited { get; set; }
    
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public DisplayRatio DisplayRatio { get; set; }
    
    [Parameter]
    public List<string> Labels { get; set; }

    [JSInvokable]
    public async Task JSDomDataPointClicked(ChartistMouseEventArgs args)
    {
        await OnDataPointClicked.InvokeAsync(args);
    }

    [JSInvokable]
    public async Task JSDomDataPointEntered(ChartistMouseEventArgs args)
    {
        await OnDataPointEntered.InvokeAsync(args);
        
    }

    [JSInvokable]
    public async Task JSDomDataPointExited(ChartistMouseEventArgs args)
    {
        await OnDataPointExited.InvokeAsync(args);
    }

    protected string ClassForRotatedHorizontalLabels()
    {
        return RotateHorizontalLabels ? "rotate-horizontal-labels" : string.Empty;
    }
    
    protected ElementReference Elem;

    protected string Id = "p" + Guid.NewGuid().ToString()[..6];
    
    
}
