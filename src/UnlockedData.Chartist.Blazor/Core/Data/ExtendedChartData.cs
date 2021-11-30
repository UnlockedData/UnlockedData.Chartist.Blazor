using System.Collections.Generic;

namespace UnlockedData.Chartist.Blazor.Core.Data;

/// <summary>
/// Defines the required extended chart data for the relevant chart types
/// </summary>
/// <seealso cref="UnlockedData.Chartist.Blazor.ChartDataBase" />
public class ExtendedChartData : ChartDataBase
{
    /// <summary>
    /// Gets or sets the series.
    /// </summary>
    /// <value>
    /// The series.
    /// </value>

    public List<SeriesData> Series { get; set; } = new List<SeriesData>();
}
