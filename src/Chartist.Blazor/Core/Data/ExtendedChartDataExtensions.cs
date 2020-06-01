using System.Collections.Generic;
using System.Linq;

namespace Chartist.Blazor.Core.Data
{
    public static class ExtendedChartDataExtensions
    {
        public static void Add(this List<Series> series, List<double?> list)
        {
            //arrange            
            var seriesPoints = new List<SeriesPoint>();

            
            int i = 0;
            //assert
            foreach (var items in list) {

                seriesPoints.Add(new SeriesPoint { Y = list[i], Meta = new PointMetaInfo() });
                i++;
            }

            series.Add(new Series { Data = seriesPoints });

            

        }

        public static void Add(this List<Series> series, List<double> list)
        {
            //arrange            
            var seriesPoints = new List<SeriesPoint>();


            int i = 0;
            //assert
            foreach (var items in list)
            {

                seriesPoints.Add(new SeriesPoint { Y = list[i], Meta = new PointMetaInfo() });
                i++;
            }

            series.Add(new Series { Data = seriesPoints });



        }
    }

        
}
