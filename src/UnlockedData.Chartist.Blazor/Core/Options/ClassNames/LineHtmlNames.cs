namespace UnlockedData.Chartist.Blazor 
{
    /// <summary>
    /// Defines the html class names that apply styling to a Line chart
    /// </summary>
    /// <seealso cref="UnlockedData.Chartist.Blazor.ExtendedHtmlNames" />
    public class LineHtmlNames : ExtendedHtmlNames
    {
        /// <summary>
        /// Gets or sets the line style class name.
        /// </summary>
        /// <value>
        /// The line style class name.
        /// </value>
        public string Line { get; set; } = "ct-line";

        /// <summary>
        /// Gets or sets the point style class name.
        /// </summary>
        /// <value>
        /// The point style class name.
        /// </value>
        public string Point { get; set; } = "ct-point";

        /// <summary>
        /// Gets or sets the area style class name.
        /// </summary>
        /// <value>
        /// The area style class name.
        /// </value>
        public string Area { get; set; } = "ct-area";


        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="LineHtmlNames"/> class.
        /// </summary>
        public LineHtmlNames()
        {
            Chart = "ct-chart-line";
        } 

        #endregion
    }
}
