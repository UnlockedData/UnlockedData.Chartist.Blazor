using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace UnlockedData.Chartist.Blazor.Core.Data
{
    public class SeriesData
    {
        [JsonPropertyName("data")]
        public List<SeriesPoint> SeriesPoints {get; set;} = new List<SeriesPoint>();

        public string Name { get; set; } = "Series Not Named";

        public string Meta { get; set; } = "No Meta Info";
        
        public bool Swapped { get; set; }

        
        
    }
}
