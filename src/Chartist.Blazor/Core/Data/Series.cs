using System.Collections.Generic;

namespace Chartist.Blazor.Core.Data
{
    public class Series
    {
        public List<SeriesPoint> Data = new List<SeriesPoint>();

         public string? Name;

         public string? Meta;
    }
}
