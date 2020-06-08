using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Chartist.Blazor.Core;
using Chartist.Blazor.Core.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Charts {
    public partial class BarSeries : ComponentBase, IDisposable
    {
        // Accept data via Razor syntax
        [Parameter] public string Name { get; set; }
        [Parameter] public List<SeriesPoint> Values { get; set; }

        [Parameter] public string Meta {get;set;}

        [Parameter] 
        public RenderFragment ChildContent { get; set; }
        

        // Each time the params change, update a 'SeriesData' instance
        private readonly SeriesData data = new SeriesData();
        protected override void OnParametersSet()
        {            
            data.Name = Name;
            data.Data = Values;
            data.Meta = Meta;
        }

        // When we're first added to the UI, attach our data to parent
        // When we're removed from the UI, remove our data from parent
        [CascadingParameter] public ChartistBar OwnerChart { get; set; }      

        protected override void OnInitialized()
            => OwnerChart.Data.Series.Add(data);

        void IDisposable.Dispose()
            => OwnerChart.Data.Series.Remove(data);
    }
}