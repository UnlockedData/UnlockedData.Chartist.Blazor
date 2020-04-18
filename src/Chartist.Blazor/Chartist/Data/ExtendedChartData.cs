﻿using System.Collections.Generic;

namespace Chartist.Blazor
{
    public class ExtendedChartData : ChartDataBase
    {
        public List<List<double?>> Series { get; set; } = new List<List<double?>>();
    }

}