using Chartist.Blazor.Core.Data;

namespace Chartist.Blazor.Services
{
    public class ChartistMouseEventArgs    
    {
        
        //taken from the ct-meta of the dom element
        public PointMetaInfo PointMetaInfo {get; set;} 

        //taken from the ct-value attr
        public double Value {get; set;}

        //parent node ct-series-name
        public string SeriesName {get; set;} 
    }
}
