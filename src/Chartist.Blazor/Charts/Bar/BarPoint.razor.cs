using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Chartist.Blazor.Core;
using Chartist.Blazor.Core.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Charts {
    public class BarPoint : ComponentBase, IDisposable
    {
        
        // Accept data via Razor syntax
        [Parameter]
        public double? X { get; set; } = null;

        [Parameter]
        public double? Y { get; set; } = null;

        [Parameter]
        public PointMetaInfo Meta { get; set; } = new PointMetaInfo();        

         [CascadingParameter] public BarSeries OwnerSeries { get; set; } 
        

        // Each time the params change, update a 'SeriesPoint' instance
        private readonly SeriesPoint point = new SeriesPoint();
        protected override void OnParametersSet()
        {            
            point.X = X;
            point.Y = Y;
            point.Meta = Meta;
        }

        protected override void OnInitialized()
        {
            OwnerSeries.SeriesPoints.Add(point);
        } 
            

        void IDisposable.Dispose()
            => OwnerSeries.SeriesPoints.Remove(point);
    }
}
