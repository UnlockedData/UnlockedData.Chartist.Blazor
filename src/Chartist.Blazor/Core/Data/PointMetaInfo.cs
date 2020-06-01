using System;

namespace Chartist.Blazor.Core.Data
{
    public class PointMetaInfo {
        public string Id {get; set;} = Guid.NewGuid().ToString();
        public string Label {get; set;} = "No Label";        
    }
}
