namespace UnlockedData.Chartist.Blazor
{
    /// <summary>
    /// Defines the html class names that apply styling to a Bar chart
    /// </summary>
    /// <seealso cref="UnlockedData.Chartist.Blazor.ExtendedHtmlNames" />
    public class BarHtmlNames : ExtendedHtmlNames
    {

        /// <summary>
        /// Gets or sets the horizontal bars styling class name.
        /// </summary>
        /// <value>
        /// The horizontal bars styling class name.
        /// </value>
        public string HorizontalBars { get; set; } = "ct-horizontal-bars";

        /// <summary>
        /// Gets or sets the bar styling class name.
        /// </summary>
        /// <value>
        /// The bar styling class name.
        /// </value>
        public string Bar { get; set; } = "ct-bar";

        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="BarHtmlNames"/> class.
        /// </summary>
        public BarHtmlNames()
        {
            Chart = "ct-chart-bar";
        }

        #endregion
    }
}
