namespace Chartist.Blazor
{
    public class BarOptions : ExtendedChartBaseOptions
    {
        public double SeriesBarDistance { get; set; } = 15;
        public double ReferenceValue { get; set; } = 0;
        public bool StackBars { get; set; } = false;
        public string StackMode { get; set; } = "accumulate"; //enum accumulate/overlap
        public bool HorizontalBars { get; set; } = false;

        public bool DistributeSeries { get; set; } = false;
        public BarHtmlNames ClassNames { get; set; } = new BarHtmlNames();
    }
}
