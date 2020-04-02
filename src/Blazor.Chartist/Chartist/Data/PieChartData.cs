using System.Collections.Generic;

namespace Chartist.Blazor.Chartist.Data
{
    public class PieChartData : ChartDataBase
    {
        public List<double> Series { get; set; } = new List<double>();

    }

}
