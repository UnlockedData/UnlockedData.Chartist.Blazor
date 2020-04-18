namespace Chartist.Blazor { 
    public class LineOptions : ExtendedChartBaseOptions
    {
        public bool ShowLine { get; set; } = true;
        public bool ShowPoint { get; set; } = true;
        public bool ShowArea { get; set; } = false;
        public double AreaBase { get; set; } = 0;
        public bool LineSmooth { get; set; } = true;
        public bool FullWidth { get; set; } = false;

        public LineHtmlNames ClassNames { get; set; } = new LineHtmlNames();
        public string LabelDirection { get; set; } = "neutral";
        public bool IgnoreEmptyValues { get; set; } = false;

    }
}
