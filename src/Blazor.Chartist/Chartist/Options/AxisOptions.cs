namespace Chartist.Blazor.Chartist.Options
{

    public class AxisOptions
    {
        public double Offset { get; set; } = 30;
        public string Position { get; set; } = "end";

        public LabelOffset LabelOffset { get; set; } = new LabelOffset();

        public bool ShowLabel { get; set; } = true;

        public bool ShowGrid { get; set; } = true;

        public double ScaleMinSpace { get; set; } = 30;


        //public string? Type { get; set; }

        public bool OnlyInteger { get; set; } = false;

        public static AxisOptions Load(string axis)
        {
            if (axis == "y")
            {
                return new AxisOptions
                {
                    Offset = 30,
                    Position = "start",
                    LabelOffset = new LabelOffset(),
                    ShowLabel = true,
                    ShowGrid = true,
                    ScaleMinSpace = 30,
                    OnlyInteger = false

                };
            }
            else if (axis == "x")
            {
                return new AxisOptions
                {
                    Offset = 30,
                    Position = "end",
                    LabelOffset = new LabelOffset(),
                    ShowLabel = true,
                    ShowGrid = true,
                    ScaleMinSpace = 30,
                    OnlyInteger = false

                };
            }
            else
                return new AxisOptions
                {
                    Offset = 30,
                    Position = "end",
                    LabelOffset = new LabelOffset(),
                    ShowLabel = true,
                    ShowGrid = true,
                    ScaleMinSpace = 30,
                    OnlyInteger = false

                };
        }

    }

}
