using System;
using System.Collections.Generic;
using System.Linq;

namespace Chartist.Blazor.Core.Data
{
    public class Series
    {
        public List<SeriesPoint> Data {get; set;} = new List<SeriesPoint>();

        public string Name { get; set; } = "Series Not Named";

        public string Meta { get; set; } = "No Meta Info";

        
        
    }
}
