using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Xunit;
/// <summary>
/// These tests are mainly in place to help get some clarity over what and how is passed
/// to razor components
/// </summary>
namespace Chartist.Blazor.UnitTests
{
    public class ChartDataShould
    {
        [Fact]
        public void ProvideSerializedDataForInterop()
        {
            //arrange
            var sut = new ExtendedChartData();

            sut.Labels = new List<string>{
                "test 1",
                "test 2",
                "test 3"

            };

            sut.Series.Add(
                new List<double> { 1.0, 2.0, 3.0 });



            sut.Series.Add(
                new List<double> { 4.0, 5.0, 6.0 }
               );

            //act
            var compare = JsonSerializer.Serialize(sut);

            //assert
            Assert.True(compare == "{\"Series\":[[1,2,3],[4,5,6]],\"Labels\":[\"test 1\",\"test 2\",\"test 3\"]}");
        }
    }
}
