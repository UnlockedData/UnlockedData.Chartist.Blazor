using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Chartist.Blazor.Core;
using Chartist.Blazor.Core.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Charts
{
    public partial class ChartistLine : ChartBase
    {
        [Inject]
        private IJSRuntime JS { get; set; }        

        [Parameter] 
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public ExtendedChartData Data { get; set; } = new ExtendedChartData();

        [Parameter]
        public LineOptions Options { get; set; } = new LineOptions();

        
        [Parameter]
        public List<string> Labels { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Data.Labels = Labels ?? Data.Labels;
            
            var objectRef = DotNetObjectReference.Create(this);           

            if (firstRender)
            {                
                await JS.InvokeVoidAsync("bizzyChartist.createChart", "Line", elem, Data, Options, objectRef);
            }

            await JS.InvokeVoidAsync("bizzyChartist.updateChart", elem, Data, Options, objectRef);
        }
    }
}
