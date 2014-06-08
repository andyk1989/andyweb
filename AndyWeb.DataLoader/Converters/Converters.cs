using CsvHelper.TypeConversion;
using System;
using System.Globalization;

namespace AndyWeb.DataLoader
{
    public class DateTimeConverter : DefaultTypeConverter
    {
        public override bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public override object ConvertFromString(TypeConverterOptions options, string text)
        {
            return DateTime.ParseExact(text, "yyyyMMdd", CultureInfo.InvariantCulture);
        }
    }

    public class NotNullableIntConverter : DefaultTypeConverter
    {
        public override bool CanConvertFrom(Type type)
        {
            return true;
        }

        public override object ConvertFromString(TypeConverterOptions options, string text)
        {
            return !string.IsNullOrWhiteSpace(text) ? int.Parse(text) : 0;
        }
    }

    public class NotNullableLongConverter : DefaultTypeConverter
    {
        public override bool CanConvertFrom(Type type)
        {
            return true;
        }

        public override object ConvertFromString(TypeConverterOptions options, string text)
        {
            return !string.IsNullOrWhiteSpace(text) ? long.Parse(text) : 0L;
        }
    }

    public class TimeConverter : DefaultTypeConverter
    {
        public override bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public override object ConvertFromString(TypeConverterOptions options, string text)
        {
            int dayModifier = 0;

            while (int.Parse(text.Substring(0, 2)) > 23)
            {
                text = (int.Parse(text.Substring(0, 2)) - 24).ToString("00") + text.Substring(2);
                dayModifier++;
            }

            return DateTime.ParseExact(text, "HH:mm:ss", CultureInfo.InvariantCulture).AddDays(dayModifier);
        }
    }

    public class TimeSpanConverter : DefaultTypeConverter
    {
        public override bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public override object ConvertFromString(TypeConverterOptions options, string text)
        {
            int dayModifier = 0;

            while (int.Parse(text.Substring(0, 2)) > 23)
            {
                text = (int.Parse(text.Substring(0, 2)) - 24).ToString("00") + text.Substring(2);
                dayModifier++;
            }

            return TimeSpan.FromDays(dayModifier) + TimeSpan.ParseExact(text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
        }
    }
}