namespace Chartist.Blazor
{
    public class ExtendedChartBaseOptions : ChartBaseOptions
    {
        public bool ShowGridBackground { get; set; } = false;

        public ChartPadding ChartPadding { get; set; } = new ChartPadding();
    }
}
