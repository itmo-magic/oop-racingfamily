using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;

namespace RacingFamily.Converters;

public class MultiAttributeConverter : IMultiValueConverter
{
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        return new List<object?>(values);
    }
}