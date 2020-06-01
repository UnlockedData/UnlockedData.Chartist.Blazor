using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Xunit;
using Chartist.Blazor.Core.Data;
using System.Reflection.Emit;
/// <summary>
/// These tests are mainly in place to help get some clarity over what and how is passed
/// to razor components
/// </summary>
namespace Chartist.Blazor.UnitTests.Core.Core.Data
{
    public class ChartDataShould
    {        
        [Fact]
        public void ProvideSerializedDataForInterop()
        {
            //arrange
            //var series = new Series();
            //series.Data = new List<SeriesPoint>{
            //    new SeriesPoint(){Y=2,Meta=new PointMetaInfo{Label="Clickable"} },
            //    new SeriesPoint(){Y=3,Meta=new PointMetaInfo{Label="Clickable"} },
            //    new SeriesPoint(){Y=4,Meta=new PointMetaInfo{Label="Clickable"} },
            //    new SeriesPoint(){Y=6,Meta=new PointMetaInfo{Label="Clickable"} },
            //    new SeriesPoint(){Y=1,Meta=new PointMetaInfo{Label="Clickable"} }
            //};
            //series.Name = "Single";
            //series.Meta = "MetaTest";

            //var sut = new ExtendedChartData() {
            //    Labels = new List<string>{"Monday","Tuesday","Weds","Thurs","Friday"},
                
            //};

            //sut.Series.Add(series);
            
            ////act
            //var compare3 = JsonSerializer.Serialize(series.Data);
            //var compare4 = JsonSerializer.Serialize(series.Data[0]);
            //var compare1 = JsonSerializer.Serialize(series);
            //var compare2 = JsonSerializer.Serialize(sut.Series);
            //var compare = JsonSerializer.Serialize(sut);

            //// //assert
            //// Assert.True(compare == "{\"Series\":[[1,2,3],[4,5,6]],\"Labels\":[\"test 1\",\"test 2\",\"test 3\"]}");
        }
    }
}
