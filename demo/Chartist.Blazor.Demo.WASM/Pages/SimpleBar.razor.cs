using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Chartist.Blazor.Core.Data;
using Chartist.Blazor.Services;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Demo.WASM.Pages
{
    public partial class SimpleBar : ComponentBase
    {
        
        
        private ExtendedChartData BiPolarData { get; set; }        
       
        private BarOptions BiPolarOptions { get; set; } = new BarOptions();

        protected override void OnInitialized()
        {
            

            BiPolarData = new Core.Data.ExtendedChartData()
            {

                Labels = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }

            };


            var series = new Series();
            series.Data.Add(new SeriesPoint { X = null, Y = 12, Meta = new PointMetaInfo { Label = "Monday"} });
            series.Data.Add(new SeriesPoint { X = null, Y = 9, Meta = new PointMetaInfo{ Label = "Tuesday"}});
            series.Data.Add(new SeriesPoint { X = null, Y = 7, Meta = new PointMetaInfo{ Label = "Wednesday"} });
            series.Data.Add(new SeriesPoint { X = null, Y = 8, Meta = new PointMetaInfo{ Label = "Thursday"} });
            series.Data.Add(new SeriesPoint { X = null, Y = 5, Meta = new PointMetaInfo{ Label = "Friday"} });
            BiPolarData.Series.Add(series);

        }

        protected override void OnAfterRender(bool firstRender)
        {
            DomEventRoutingService.DataPointClicked += (o, e) =>
            {
                Console.WriteLine("clicked a simple bar when you clicked me " + e.PointMetaInfo.Id + " " + e.PointMetaInfo.Label);
            };
        }



    }
}
