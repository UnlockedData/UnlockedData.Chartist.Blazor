using System;
using System.Collections.Generic;
using System.Text;

using UnlockedData.Chartist.Blazor.Core.Data;

namespace UnlockedData.Chartist.Blazor.UnitTests.Core.Core.Data
{
    public static class TestDataFactory
    {
        
        public static ExtendedChartData UnlabelledData()
        {
            var result = new ExtendedChartData()
            {

                Labels = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }

            };


            var series = new SeriesData();
            series.SeriesPoints.Add(new SeriesPoint { Y = 12 });
            series.SeriesPoints.Add(new SeriesPoint { Y = 9 });
            series.SeriesPoints.Add(new SeriesPoint { Y = 7 });
            series.SeriesPoints.Add(new SeriesPoint { Y = 8 });
            series.SeriesPoints.Add(new SeriesPoint { Y = 5 });
            result.Series.Add(series);

            return result;
        }
    }
}
