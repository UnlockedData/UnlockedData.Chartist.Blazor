using System.Collections.Generic;

namespace Chartist.Blazor.Core.Data
{
    public class Series
    {
        public List<SeriesPoint> Data {get; set;} = new List<SeriesPoint>();

         public string Name {get; set;} 

         public string Meta {get; set;}  
    }
}
