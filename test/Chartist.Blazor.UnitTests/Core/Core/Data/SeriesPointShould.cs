using Chartist.Blazor.Core.Data;
using Xunit;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            Meta= new PointMetaInfo{Label="label"}
        };
            //When
            var compare = JsonSerializer.Serialize(sut);
        //Then

        }
    }
}
