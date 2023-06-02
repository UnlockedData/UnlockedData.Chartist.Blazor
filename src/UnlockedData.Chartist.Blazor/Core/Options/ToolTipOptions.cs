using System.Text.Json.Serialization;
using UnlockedData.Chartist.Blazor.Extensions;
namespace UnlockedData.Chartist.Blazor;

public class ToolTipOptions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Currency { get; set; }
    public bool ShowSeriesName { get; set; } = false;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Class { get; set; }
  
    [JsonConverter(typeof(EnumAsStringCamelCaseConverter<LabelInterpolationOption>))]
    public LabelInterpolationOption TransformTooltipTextFunction { get; set; } = LabelInterpolationOption.CommaSeparated;
    
    public bool AnchorToPoint { get; set; } = false;
    public bool AppendToBody {get;set;} = false;
}