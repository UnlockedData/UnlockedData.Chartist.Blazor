using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Chartist.Blazor.Core.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Demo.WASM.Pages
{
    public partial class HorizontalBar : ComponentBase
    {
       
        
        private ExtendedChartData HorizontalBarData { get; set; }        
       
        private BarOptions HorizontalOptions { get; set; } = new BarOptions { HorizontalBars = true };

        protected override void OnInitialized()
        {
            HorizontalBarData = new Core.Data.ExtendedChartData()
            {

                Labels = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }

            };


            var series = new Series();
            series.Data.Add(new SeriesPoint { X = null, Y = 12, Meta = "Monday" });
            series.Data.Add(new SeriesPoint { X = null, Y = 9, Meta = "Tuesday" });
            series.Data.Add(new SeriesPoint { X = null, Y = 7, Meta = "Wednesday" });
            series.Data.Add(new SeriesPoint { X = null, Y = 8, Meta = "Thursday" });
            series.Data.Add(new SeriesPoint { X = null, Y = 5, Meta = "Friday" });
            HorizontalBarData.Series.Add(series);

        }

        


    }
}
