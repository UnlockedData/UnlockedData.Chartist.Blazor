﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Chartist.Blazor.Core;
using Chartist.Blazor.Core.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Charts
{
    public partial class ChartistEventedLine : EventedChartBase
    {
        [Inject]
        private IJSRuntime JS { get; set; }

        [Parameter] 
        public Dictionary<string,object> ExtraAttributes { get; set; }

        [Parameter] 
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public ExtendedChartData Data { get; set; }

        [Parameter]
        public LineOptions Options { get; set; }
             
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (Options == null)
                Options = new LineOptions();
                       

            if (firstRender)
            {
                var objectRef = DotNetObjectReference.Create(this);
                await JS.InvokeVoidAsync("bizzyChartist.createEventedChart", "Line", elem, Data, Options, objectRef);
            }
        }
    }
}
