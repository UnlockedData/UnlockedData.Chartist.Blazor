using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Chartist.Blazor.Core;
using Chartist.Blazor.Core.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Charts {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1063:Implement IDisposable Correctly", Justification = "<Pending>")]
    public partial class LineSeries : ComponentBase, IDisposable
    {
        
        // Accept data via Razor syntax
        [Parameter] public string Name { get; set; }

        [Parameter]
        public List<SeriesPoint> SeriesPoints { get; set; } = new List<SeriesPoint>();

        [Parameter] public string Meta {get;set;}

        [Parameter] 
        public RenderFragment ChildContent { get; set; }
        

        // Each time the params change, update a 'SeriesData' instance
        private readonly SeriesData _seriesData = new SeriesData();
        protected override void OnParametersSet()
        {
            _seriesData.Name = Name;
            _seriesData.SeriesPoints = SeriesPoints;
            _seriesData.Meta = Meta;
        }

        // When we're first added to the UI, attach our data to parent
        // When we're removed from the UI, remove our data from parent
        [CascadingParameter] public ChartistLine OwnerChart { get; set; }

        protected override void OnInitialized()
            => OwnerChart.Data.Series.Add(_seriesData);


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1063:Implement IDisposable Correctly", Justification = "<Pending>")]
        void IDisposable.Dispose()
            => OwnerChart.Data.Series.Remove(_seriesData);
    }
}
