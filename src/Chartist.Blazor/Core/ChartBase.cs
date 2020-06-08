using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Core
{
    public abstract class ChartBase : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)] 
        public Dictionary<string,object> ExtraAttributes { get; set; }
        
        [Parameter]
        public EventCallback<ChartistMouseEventArgs> OnDataPointClicked { get; set; }

        [Parameter]
        public EventCallback<ChartistMouseEventArgs> OnDataPointEntered { get; set; }

        [Parameter]
        public EventCallback<ChartistMouseEventArgs> OnDataPointExited { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal")]
        protected ElementReference elem;

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
    }
}
