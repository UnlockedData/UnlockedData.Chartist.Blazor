namespace Chartist.Blazor 
{ 
    public class LineHtmlNames : ExtendedHtmlNames
    {
        public string Line { get; set; } = "ct-line";
        public string Point { get; set; } = "ct-point";
        public string Area { get; set; } = "ct-area";

        public LineHtmlNames()
        {
            Chart = "ct-chart-line";
        }

    }





}
