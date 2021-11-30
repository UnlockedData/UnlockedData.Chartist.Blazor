namespace UnlockedData.Chartist.Blazor
{
    /// <summary>
    /// Defines the extended html class names that apply styling to relevant chart types
    /// </summary>
    /// <seealso cref="UnlockedData.Chartist.Blazor.HtmlNamesBase" />
    public class ExtendedHtmlNames : HtmlNamesBase
    {
        /// <summary>
        /// Gets or sets the overall chart styling class name.
        /// </summary>
        /// <value>
        /// The chart styling class name.
        /// </value>
        public string Chart { get; set; }

        /// <summary>
        /// Gets or sets the label group styling class name.
        /// </summary>
        /// <value>
        /// The label group styling class name.
        /// </value>
        public string LabelGroup { get; set; } = "ct-labels";

        /// <summary>
        /// Gets or sets the grid styling class name.
        /// </summary>
        /// <value>
        /// The grid styling class name.
        /// </value>
        public string Grid { get; set; } = "ct-grid";

        /// <summary>
        /// Gets or sets the grid group styling class name.
        /// </summary>
        /// <value>
        /// The grid group styling class name.
        /// </value>
        public string GridGroup { get; set; } = "ct-grids";

        /// <summary>
        /// Gets or sets the grid background styling class name.
        /// </summary>
        /// <value>
        /// The grid background styling class name.
        /// </value>
        public string GridBackground { get; set; } = "ct-grid-background";

        /// <summary>
        /// Gets or sets the vertical styling class name.
        /// </summary>
        /// <value>
        /// The vertical styling class name.
        /// </value>
        public string Vertical { get; set; } = "ct-vertical";

        /// <summary>
        /// Gets or sets the horizontal styling class name.
        /// </summary>
        /// <value>
        /// The horizontal styling class name.
        /// </value>
        public string Horizontal { get; set; } = "ct-horizontal";

        /// <summary>
        /// Gets or sets the start styling class name.
        /// </summary>
        /// <value>
        /// The start styling class name.
        /// </value>
        public string Start { get; set; } = "ct-start";

        /// <summary>
        /// Gets or sets the end styling class name.
        /// </summary>
        /// <value>
        /// The end styling class name.
        /// </value>
        public string End { get; set; } = "ct-end";
    }
}
