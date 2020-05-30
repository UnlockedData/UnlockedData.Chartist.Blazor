using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using BarChartData = Chartist.Blazor.Core.Data.ExtendedChartData;

namespace Chartist.Blazor.Charts
{
    public partial class ChartistBar : ComponentBase
    {



        [Inject]
        public IJSRuntime JS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending>")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        private ElementReference elem;

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> ExtraAttributes { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        //[Parameter]
        //public ChartType Type { get; set; }

        [Parameter]
        public BarChartData Data { get; set; }

        [Parameter]
        public BarOptions Options { get; set; }

               

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {

            

            if (Options == null)
            {
                Options = new BarOptions();
                
            }

            if (Options.HorizontalBars)
            {
                foreach (var series in Data.Series)
                {
                    foreach (var point in series.Data)
                    {
                        point.SwapPoints();
                    }
                }
            }

            if (firstRender)
            {

                await JS.InvokeVoidAsync("bizzyChartist.createChart", "Bar", elem, Data, Options);


            }




        }
    }
}
