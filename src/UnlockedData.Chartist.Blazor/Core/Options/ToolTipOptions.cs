using System.Text.Json.Serialization;
namespace UnlockedData.Chartist.Blazor;

public class ToolTipOptions
{
    public string Currency { get; set; }
    public bool ShowSeriesName { get; set; } = false;
    
}