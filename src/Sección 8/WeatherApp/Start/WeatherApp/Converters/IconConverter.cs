using System;
using System.Globalization;

namespace WeatherApp.Converters
{
    public class IconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var iconType = value.ToString();

            switch (iconType)
            {
                case "01n":
                    return "moon.png";
                case "01d":
                    return "sun.png";
                case "02n":
                case "02d":
                case "04d":
                    return "cloud.png";
                case "10d":
                    return "rain.png";
                default:
                    return "cloud.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}