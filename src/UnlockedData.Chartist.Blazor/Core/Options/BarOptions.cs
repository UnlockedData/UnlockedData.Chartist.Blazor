using System.Text.Json.Serialization;

using UnlockedData.Chartist.Blazor.Extensions;

namespace UnlockedData.Chartist.Blazor;

/// <summary>
/// Defines the Bar Chart Options
/// </summary>
/// <seealso cref="UnlockedData.Chartist.Blazor.ExtendedChartBaseOptions" />
public class BarOptions : ExtendedChartBaseOptions
{
    /// <summary>
    /// Gets or sets the series bar distance.
    /// </summary>
    /// <value>
    /// The series bar distance.
    /// </value>
    /// <remarks>
    /// Default value is 15
    /// </remarks>
    public double SeriesBarDistance { get; set; } = 15;

    /// <summary>
    /// Gets or sets the reference value.
    /// </summary>
    /// <value>
    /// The reference value.
    /// </value>
    /// <remarks>
    /// Default value is 0
    /// </remarks>
    public double ReferenceValue { get; set; } = 0;

    /// <summary>
    /// Gets or sets a value indicating whether the bars should be stacked.
    /// </summary>
    /// <value>
    ///   <c>true</c> if the bars should be stacked; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Default value is <c>false</c>
    /// </remarks>
    public bool StackBars { get; set; } = false;


    /// <summary>
    /// Gets or sets the stack mode.
    /// </summary>
    /// <value>
    /// The stack mode.
    /// </value>
    /// <remarks>
    /// Default value is 'accumulate'
    /// </remarks>
    [JsonConverter(typeof(EnumAsStringCamelCaseConverter<StackMode>))]
    public StackMode StackMode { get; set; } = StackMode.Accumulate; //enum accumulate/overlap


    /// <summary>
    /// Gets or sets a value indicating whether the bars should be horizontal.
    /// </summary>
    /// <value>
    ///   <c>true</c> if the bars should be horizontal; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Default value is <c>false</c>
    /// </remarks>
    public bool HorizontalBars { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether to distribute series.
    /// </summary>
    /// <value>
    ///   <c>true</c> if the series should be distributed; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Default value is <c>false</c>
    /// </remarks>
    public bool DistributeSeries { get; set; } = false;

    /// <summary>
    /// Gets or sets the html class names to use for styling.
    /// </summary>
    /// <value>
    /// The class names.
    /// </value>
    public BarHtmlNames ClassNames { get; set; } = new BarHtmlNames();
}
