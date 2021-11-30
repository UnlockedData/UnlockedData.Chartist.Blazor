namespace UnlockedData.Chartist.Blazor
{
    /// <summary>
    /// Defines a the basic options for all charts.
    /// </summary>
    public class ChartBaseOptions
    {
        /// <summary>
        /// Gets or sets the x axis options.
        /// </summary>
        /// <value>
        /// The axis y axis options.
        /// </value>
        public AxisOptions AxisX { get; set; } = AxisOptions.Load("x");

        /// <summary>
        /// Gets or sets the y axis options.
        /// </summary>
        /// <value>
        /// The y axis options.
        /// </value>
        public AxisOptions AxisY { get; set; } = AxisOptions.Load("y");

        /// <summary>
        /// Gets or sets a value indicating whether the data should be reversed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the data should be reversed; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>
        /// Default value is <c>false</c>
        /// </remarks>
        public bool ReverseData { get; set; } = false;


        /* TODO : commented out as current blazor will not allow serialisation options to be changed. Update it dotnet 5 (breaking change)
       
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets the high value.
        /// </summary>
        /// <value>
        /// The high value.
        /// </value>
        public double? High { get; set; }

        /// <summary>
        /// Gets or sets the low value.
        /// </summary>
        /// <value>
        /// The low value.
        /// </value>
        public double? Low { get; set; }

        */
    }
}
