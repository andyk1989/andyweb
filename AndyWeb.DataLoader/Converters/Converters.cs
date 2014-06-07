using CsvHelper.TypeConversion;
using System;
using System.Globalization;

namespace AndyWeb.DataLoader
{
    public class DateTimeConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(TypeConverterOptions options, string text)
        {
            return DateTime.ParseExact(text, "yyyyMMdd", CultureInfo.InvariantCulture);
        }

        public override bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }
    }

    public class TimeConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(TypeConverterOptions options, string text)
        {
            text = int.Parse(text.Substring(0, 2)) > 23 ? (int.Parse(text.Substring(0, 2)) - 24).ToString("00") + text.Substring(2) : text;

            return DateTime.ParseExact(text, "HH:mm:ss", CultureInfo.InvariantCulture);
        }

        public override bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }
    }
}
