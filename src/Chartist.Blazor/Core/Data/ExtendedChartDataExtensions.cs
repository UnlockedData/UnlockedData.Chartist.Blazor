using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace Chartist.Blazor.Core.Data
{
    public static class ExtendedChartDataExtensions
    {
        public static void Add(this List<SeriesData> series, List<double?> list, string name = "Series Not Named")
        {
            //arrange            
            var seriesPoints = new List<SeriesPoint>();

            
            int i = 0;
            //assert
            foreach (var items in list) {

                seriesPoints.Add(new SeriesPoint { Y = list[i], Meta = new PointMetaInfo() });
                i++;
            }

            series.Add(new SeriesData { Data = seriesPoints, Name = name });

            

        }

        public static void Add(this List<SeriesData> series, List<double> list, string name = "Series Not Named")
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

            series.Add(new SeriesData { Data = seriesPoints, Name = name });



        }

        //if you provide a label collectionn, use this to populate the metainfo points
        //TODO: add a exception catch when the length of lables is shorter than the list
        //TODO: add testing
        public static void Add(this List<SeriesData> series, List<double?> list, List<string> labels, string name = "Series Not Named")
        {
            //arrange            
            var seriesPoints = new List<SeriesPoint>();


            int i = 0;
            //assert
            foreach (var items in list)
            {

                seriesPoints.Add(new SeriesPoint { Y = list[i], Meta = new PointMetaInfo { Label = labels[i] } });
                i++;
            }

            series.Add(new SeriesData { Data = seriesPoints, Name = name });



        }

        //if you provide a label collection, use this to populate the metainfo points
        public static void Add(this List<SeriesData> series, List<double?> list, ExtendedChartData parent, string name = "Series Not Named")
        {
            series.Add(list, parent.Labels, name);


        }

        //if you provide a label collection, use this to populate the metainfo points
        //TODO: add a exception catch when the length of lables is shorter than the list
        //TODO: add testing
        public static void Add(this List<SeriesData> series, List<double> list, List<string> labels, string name = "Series Not Named")
        {
            //arrange            
            var seriesPoints = new List<SeriesPoint>();


            int i = 0;
            //assert
            foreach (var items in list)
            {

                seriesPoints.Add(new SeriesPoint { Y = list[i], Meta = new PointMetaInfo { Label = labels[i] } });
                i++;
            }

            series.Add(new SeriesData { Data = seriesPoints, Name = name });



        }

        //if you provide a label collection, use this to populate the metainfo points
        public static void Add(this List<SeriesData> series, List<double> list, ExtendedChartData parent, string name = "Series Not Named")
        {
            series.Add(list, parent.Labels, name);

        }

        
    }

        
}
