using System.Text.Json.Serialization;

namespace UnlockedData.Chartist.Blazor;

public class InterpolationOptions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

    public bool? FillHoles { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

    public double? Divisor { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

    public double? Tension { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

    public bool? Postpone { get; set; }
}
