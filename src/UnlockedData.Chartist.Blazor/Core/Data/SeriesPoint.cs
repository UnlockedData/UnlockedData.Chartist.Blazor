namespace UnlockedData.Chartist.Blazor.Core.Data;

public class SeriesPoint : SeriesPointBase
{

}

public class SeriesPointBase
{
    public double? X { get; set; }
    public double? Y { get; set; } 

    public PointMetaInfo Meta { get; set; } = new PointMetaInfo();
}