using System.Collections.Generic;

namespace Chartist.Blazor
{
    /// <summary>
    /// Defines the data required for a Pie chart.
    /// </summary>
    /// <seealso cref="Chartist.Blazor.ChartDataBase" />
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
