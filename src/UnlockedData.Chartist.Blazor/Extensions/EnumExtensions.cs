using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace UnlockedData.Chartist.Blazor.Extensions;

public static class EnumExtensions
{
    
    public static string Description<TEnum>(this TEnum e) where TEnum : IConvertible
    {
        if ((object) e is Enum)
        {
            Type type = e.GetType();
            foreach (int num in Enum.GetValues(type))
            {
                if (num == e.ToInt32((IFormatProvider) CultureInfo.InvariantCulture))
                    return (((IEnumerable<object>) type.GetMember(type.GetEnumName((object) num))[0].GetCustomAttributes(typeof (DescriptionAttribute), false)).FirstOrDefault<object>() is DescriptionAttribute descriptionAttribute ? descriptionAttribute.Description : (string) null) ?? e.ToString();
            }
        }
        return string.Empty;
    }
}
