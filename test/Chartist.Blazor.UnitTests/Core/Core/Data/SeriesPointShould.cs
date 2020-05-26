using Chartist.Blazor.Core.Data;
using Xunit;

namespace Chartist.Blazor.UnitTests.Core.Core.Data
{
    public class SeriesPointShould
    {
        [Fact]
        public void ToStringForJsonCorrectly()
        {
        //Given
        var sut = new SeriesPoint(){
            Y=1.00,
            Meta="ClickMe"
        };
        //When
        var compare = sut.ToString();
        //Then

        }
    }
}