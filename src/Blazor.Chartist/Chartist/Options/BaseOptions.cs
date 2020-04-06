namespace Chartist.Blazor
{ 
    /// <summary>
    /// the commented out bits are like this because at present, blazor will not allow you to amend serialisation options 
    /// to ignore nulls. This feature is coming in dotnet 5
    /// </summary>
    public class ChartBaseOptions
    {

        //public double? Width { get; set; }


        //public double? Height { get; set; }

        public AxisOptions AxisX { get; set; } = AxisOptions.Load("x");
        public AxisOptions AxisY { get; set; } = AxisOptions.Load("y");


        //public double? High { get; set; }


        //public double? Low { get; set; }

        public bool ReverseData { get; set; } = false;

    }
}
