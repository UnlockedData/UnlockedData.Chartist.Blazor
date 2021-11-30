using System.Collections.Generic;

using UnlockedData.Chartist.Blazor.Core.Data;

using Xunit;

namespace UnlockedData.Chartist.Blazor.UnitTests.Core.Core.Data
{
    public class ExtendedChartDataExtensionsShould
    {
        [Fact]
        public void ConvertListOfDoubleWhenUsingAddOverride()
        {
            //arrange
            var testList = new List<double?> { 0, 1, 2, 4, 5 };
            var sut = new ExtendedChartData();

            //act
            sut.Series.Add(testList);
            int i = 0;
            //assert
            foreach (var items in testList)
            {
                Assert.Null(sut.Series[0].SeriesPoints[i].X);
                Assert.Equal(testList[i], sut.Series[0].SeriesPoints[i].Y);
                i++;
            }
            
        }

    }
}
