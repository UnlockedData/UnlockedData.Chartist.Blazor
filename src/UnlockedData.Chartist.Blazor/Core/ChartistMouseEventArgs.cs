using UnlockedData.Chartist.Blazor.Core.Data;

namespace UnlockedData.Chartist.Blazor;

public class ChartistMouseEventArgs : SeriesPointBase
{
    //taken from the ct-meta of the dom element
    public PointMetaInfo PointMetaInfo { get; set; }

}
