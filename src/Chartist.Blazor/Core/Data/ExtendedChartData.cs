using System.Collections.Generic;
using Chartist.Blazor.Chartist.Data;

namespace Chartist.Blazor.Core.Data
{
    /// <summary>
    /// Defines the required extended chart data for the relevant chart types
    /// </summary>
    /// <seealso cref="Chartist.Blazor.ChartDataBase" />
    public class ExtendedChartData : ChartDataBase
    {
        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        // public List<List<double?>> Series { get; set; } = new List<List<double?>>();
        public List<Series> Series { get; set; } = new List<Series>();

       

    }

        
}
