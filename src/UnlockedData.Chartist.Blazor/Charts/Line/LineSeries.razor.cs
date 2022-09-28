using Microsoft.AspNetCore.Components;
using UnlockedData.Chartist.Blazor.Core.Data;
namespace UnlockedData.Chartist.Blazor.Charts
{
    public partial class LineSeries : ComponentBase, IDisposable
    {
        [CascadingParameter(Name = "OwnerChart")] 
        public ChartistLine OwnerChart { get; set; }
        
        [Parameter] 
        public string Name { get; set; }

        [Parameter]
        public List<SeriesPoint> SeriesPoints { get; set; } = new();

        [Parameter] 
        public string Meta {get;set;}
    
        [Parameter] 
        public string ClassName {get;set;}
    
        [Parameter] 
        public RenderFragment ChildContent { get; set; }

        private readonly SeriesData _seriesData = new ();
        protected override void OnParametersSet()
        {
            _seriesData.Name = Name;
            _seriesData.SeriesPoints = SeriesPoints;
            _seriesData.Meta = Meta;
            _seriesData.ClassName = ClassName;
        }


        protected override void OnInitialized() => OwnerChart.Data.Series.Add(_seriesData);
    
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            OwnerChart.Data.Series.Remove(_seriesData);
        }
    }
  
}
