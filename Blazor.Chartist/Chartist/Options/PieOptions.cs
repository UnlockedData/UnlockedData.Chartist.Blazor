namespace Chartist.Blazor.Chartist.Options
{
    /// <summary>
    /// Total commented out as blazor will not allow serialisation options to be changed. Update it dotnet 5
    /// </summary>
    public class PieOptions : ChartBaseOptions
    {
        public double ChartPadding { get; set; } = 5;
        public double StartAngle { get; set; } = 0;

        //public double? Total { get; set; }
        public bool Donut { get; set; } = false;
        public bool DonutSolid { get; set; } = false;
        public double DonutWidth { get; set; } = 60;
        public double LabelOffset { get; set; } = 0;
        public string LabelPosition { get; set; } = "inside"; //enum inside, outside, center
        public string LabelDirection { get; set; } = "neutral"; //enum neutral, implode, explode

        public bool IgnoreEmptyValues { get; set; } = false;
    }
}
