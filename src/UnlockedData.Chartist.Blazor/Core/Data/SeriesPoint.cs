namespace UnlockedData.Chartist.Blazor.Core.Data
{
    public class SeriesPoint
    {
        public double? X { get; set; }

        public double? Y { get; set; } 

        public PointMetaInfo Meta { get; set; } = new PointMetaInfo();

        //if there is a horizontal bars option set, the values need to be swapped
        public void SwapPoints()
        {
            var holder = X;
            X = Y;
            Y = holder;
        }

      
    }
}
