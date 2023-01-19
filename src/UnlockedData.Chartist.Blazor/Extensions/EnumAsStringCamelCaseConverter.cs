using System;
using System.Reflection.Metadata;
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
        var result = System.Text.RegularExpressions.Regex.Replace(value.ToString(), "([A-Z])", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim();
        var words = result.Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries);
        var leadWord = words[0].ToLower();
        var tailWords = words.Skip(1)
            .Select(word => (char.ToUpper(word[0]) + word.Substring(1)))
            .ToArray();

        var bld = new StringBuilder();
        bld.Append(leadWord);
        if (tailWords.Any())
        {
            foreach (var word in tailWords)
            {
                bld.Append(word.Trim());
            }
            
        }

        writer.WriteStringValue(bld.ToString());
    }
}
