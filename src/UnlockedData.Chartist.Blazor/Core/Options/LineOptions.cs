﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using UnlockedData.Chartist.Blazor.Extensions;

namespace UnlockedData.Chartist.Blazor;

/// <summary>
/// Defines the Line Chart Options
/// </summary>
/// <seealso cref="UnlockedData.Chartist.Blazor.ExtendedChartBaseOptions" />
public class LineOptions : ExtendedChartBaseOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether to show lines.
    /// </summary>
    /// <value>
    ///   <c>true</c> if lines should be shown; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Defaults to <c>true</c>
    /// </remarks>
    public bool ShowLine { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether to show points.
    /// </summary>
    /// <value>
    ///   <c>true</c> if points should be shown; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Defaults to <c>true</c>
    /// </remarks>
    public bool ShowPoint { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether to show areaa.
    /// </summary>
    /// <value>
    ///   <c>true</c> if areas should be shown; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Defaults to <c>false</c>
    /// </remarks>
    public bool ShowArea { get; set; } 

    /// <summary>
    /// Gets or sets the area base.
    /// </summary>
    /// <value>
    /// The area base.
    /// </value>
    public double AreaBase { get; set; } = 0;

    /// <summary>
    /// The smoothing algorithm used to draw the line
    /// </summary>
    [JsonConverter(typeof(EnumAsStringCamelCaseConverter<InterpolationType>))]
    public InterpolationType InterpolationType { get; set; } = InterpolationType.Cardinal;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InterpolationOptions InterpolationOptions { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("series")]
    public Dictionary<string,LineOptions> SeriesOverrides { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the chart should be full width.
    /// </summary>
    /// <value>
    ///   <c>true</c> if the chart should be full width; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Defaults to <c>false</c>
    /// </remarks>
    public bool FullWidth { get; set; } = false;

    /// <summary>
    /// Gets or sets the html class names to use for styling.
    /// </summary>
    /// <value>
    /// The class names.
    /// </value>
    public LineHtmlNames ClassNames { get; set; } = new LineHtmlNames();

    /// <summary>
    /// Gets or sets the label direction.
    /// </summary>
    /// <value>
    /// The label direction.
    /// </value>
    /// <remarks>
    /// Default is 'neutral'
    /// </remarks>
    public string LabelDirection { get; set; } = "neutral";

    /// <summary>
    /// Gets or sets a value indicating whether [ignore empty values].
    /// </summary>
    /// <value>
    ///   <c>true</c> if [ignore empty values]; otherwise, <c>false</c>.
    /// </value>
    /// <remarks>
    /// Defaults to <c>false</c>
    /// </remarks>
    public bool IgnoreEmptyValues { get; set; } = false;
    
    
}

public enum InterpolationType
{
    None,
    Simple,
    Cardinal,
    Monotone,
    Step
}
