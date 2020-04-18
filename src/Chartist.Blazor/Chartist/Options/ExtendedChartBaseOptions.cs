namespace Chartist.Blazor
{
    /// <summary>
    /// Defines the extended options for relevant charts.
    /// </summary>
    /// <seealso cref="Chartist.Blazor.ChartBaseOptions" />
    public class ExtendedChartBaseOptions : ChartBaseOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether to show the background grid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the background grid should be shown; otherwise, <c>false</c>.
        /// </value>
        public bool ShowGridBackground { get; set; } = false;

        /// <summary>
        /// Gets or sets the chart padding.
        /// </summary>
        /// <value>
        /// The chart padding.
        /// </value>
        public ChartPadding ChartPadding { get; set; } = new ChartPadding();
    }
}
