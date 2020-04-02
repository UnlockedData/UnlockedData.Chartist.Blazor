namespace Chartist.Blazor.Chartist.Options.ClassNames
{
    public class LineClassNames : ExtendedClassNames
    {
        public string Line { get; set; } = "ct-line";
        public string Point { get; set; } = "ct-point";
        public string Area { get; set; } = "ct-area";

        public LineClassNames()
        {
            Chart = "ct-chart-line";
        }

    }





}
