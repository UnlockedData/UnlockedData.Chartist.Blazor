using System.Collections.Generic;

namespace UnlockedData.Chartist.Blazor.Core.Data
{
    /// <summary>
    /// Defines the data required for a Pie chart.
    /// </summary>
    /// <seealso cref="UnlockedData.Chartist.Blazor.ChartDataBase" />
    public class PieChartData : ChartDataBase
    {
        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        public List<double> Series { get; set; } = new List<double>();
    }
}
