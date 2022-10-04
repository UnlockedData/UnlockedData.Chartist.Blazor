using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks.Dataflow;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using UnlockedData.Chartist.Blazor.Extensions;

namespace UnlockedData.Chartist.Blazor
{
    /// <summary>
    /// Defines a chart's axis options
    /// </summary>
    public abstract class AxisOptions
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
        [JsonConverter(typeof(EnumAsStringCamelCaseConverter<LabelPosition>))]
        public LabelPosition Position { get; set; } = LabelPosition.End;

        /// <summary>
        /// Gets or sets the label offset.
        /// </summary>
        /// <value>
        /// The label offset.
        /// </value>
        public LabelOffset LabelOffset { get; set; } = new LabelOffset();

        /// <summary>
        /// You can supply a function name for this that exists on the Chartist object
        /// </summary>
        public string? LabelInterpolationFnc { get; set; } = "noop";

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

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? High { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Low { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? ReferenceValue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Divisor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<dynamic> Ticks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether only integers should be allowed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if only integers should be allowed; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>
        /// Default value is false;
        /// </remarks>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OnlyInteger { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AxisType? Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stretch { get; set; }

        #endregion

        #region factory load method

        #endregion
    }

    public class AxisYOptions : AxisOptions
    {

        public AxisYOptions()
        {
            Position = LabelPosition.Start;
            Type = null;
        }
    };

    public class AxisXOptions : AxisOptions
    {
        public AxisXOptions()
        {
        }
    };
}
