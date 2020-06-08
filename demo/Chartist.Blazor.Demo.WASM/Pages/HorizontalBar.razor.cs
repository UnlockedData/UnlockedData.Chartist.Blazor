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
            
            var series = new SeriesData();
            series.Data.Add(new SeriesPoint { X = null, Y = 12, Meta = new PointMetaInfo { Label = "Monday"} });
            series.Data.Add(new SeriesPoint { X = null, Y = 9, Meta = new PointMetaInfo{ Label = "Tuesday"}});
            series.Data.Add(new SeriesPoint { X = null, Y = 7, Meta = new PointMetaInfo{ Label = "Wednesday"} });
            series.Data.Add(new SeriesPoint { X = null, Y = 8, Meta = new PointMetaInfo{ Label = "Thursday"} });
            series.Data.Add(new SeriesPoint { X = null, Y = 5, Meta = new PointMetaInfo{ Label = "Friday"} });
            HorizontalBarData.Series.Add(series);
        }

        


    }
}
