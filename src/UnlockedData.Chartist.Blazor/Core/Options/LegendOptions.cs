using System.Text.Json.Serialization;
namespace UnlockedData.Chartist.Blazor;

public class LegendOptions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //adds class to the legend UL element
    public string? ClassName { get; set; }
        
    //Accepts a array of strings as long as the chart's series, those will be added as classes to the li elements.
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string>? ClassNames { get; set; }
        
    public bool Clickable { get; set; } = true;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string>? LegendNames { get; set; }
    public string Position { get; set; } = "top";


}