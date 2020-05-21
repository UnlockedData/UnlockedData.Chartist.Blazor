namespace Chartist.Blazor
{
    /// <summary>
    /// Defines a chart's axis options
    /// </summary>
    public class AxisOptions
    {
        #region properties

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>
        /// The offset.
        /// </value>
        public double Offset { get; set; } = 30;

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        /// <remarks>
        /// Default value is "end"
        /// </remarks>
        public string Position { get; set; } = "end";
        //TODO: define position enum

        /// <summary>
        /// Gets or sets the label offset.
        /// </summary>
        /// <value>
        /// The label offset.
        /// </value>
        public LabelOffset LabelOffset { get; set; } = new LabelOffset();

        /// <summary>
        /// Gets or sets a value indicating whether to show labels.
        /// </summary>
        /// <value>
        ///   <c>true</c> if labels should be shown; otherwise, <c>false</c>.
        /// </value>
        public bool ShowLabel { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to show the grid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the grid should be shown; otherwise, <c>false</c>.
        /// </value>
        public bool ShowGrid { get; set; } = true;

        /// <summary>
        /// Gets or sets the scale minimum space.
        /// </summary>
        /// <value>
        /// The scale minimum space.
        /// </value>
        public double ScaleMinSpace { get; set; } = 30;

        /// <summary>
        /// Gets or sets a value indicating whether only integers should be allowed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if only integers should be allowed; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>
        /// Default value is false;
        /// </remarks>
        public bool OnlyInteger { get; set; } = false;

        /* TODO: commented out as blazor will not allow serialisation options to be changed. Update it dotnet 5 (breaking change)
        
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string? Type { get; set; }
            
        */

        #endregion

        #region factory load method

        /// <summary>
        /// Loads the specified axis with default values.
        /// </summary>
        /// <param name="axis">The axis.</param>
        /// <returns><see cref="AxisOptions"/></returns>
        public static AxisOptions Load(string axis) =>
            axis switch
            {
                "y" => new AxisOptions 
                {
                    Position = "start"
                },
                _ => new AxisOptions()
            };

        #endregion
    }

}
