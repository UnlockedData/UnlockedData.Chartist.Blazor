using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UnlockedData.Chartist.Blazor.Extensions;

public class EnumAsStringCamelCaseConverter<T> : JsonConverter<T> where T : IComparable, IFormattable, IConvertible
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotSupportedException();
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        var result = value.ToString();
        // If there are 0 or 1 characters, just return the string.
        if (result == null || result.Length < 2)
        {
            writer.WriteStringValue(result);
            return;
        }
        // Split the string into words.
        
        var words = result.Split(
            new char[] { },
            StringSplitOptions.RemoveEmptyEntries);

        // Combine the words.
        var sb = new StringBuilder(words[0].ToLower());
        for (var i = 1; i < words.Length; i++)
        {
            sb.Append(words[i].Substring(0, 1).ToUpper() +
                      words[i].Substring(1));

        }
        
        writer.WriteStringValue(sb.ToString());
    }
}
