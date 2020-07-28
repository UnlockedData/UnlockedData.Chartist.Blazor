namespace Chartist.Blazor
{
    /// <summary>
    /// Defines the html class names that apply styling to all chart types
    /// </summary>
    public abstract class HtmlNamesBase
    {
        /// <summary>
        /// Gets or sets the label style class name.
        /// </summary>
        /// <value>
        /// The label style class name.
        /// </value>
        public string Label { get; set; } = "ct-label";

        /// <summary>
        /// Gets or sets the series style class name.
        /// </summary>
        /// <value>
        /// The series style class name.
        /// </value>
        public string Series { get; set; } = "ct-series";
    }
}
