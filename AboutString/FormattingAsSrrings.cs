using System;
using System.Globalization;

namespace AboutString
{
    /// <summary>
    /// Formatting is
    /// process of converting a value to a string
    /// The object base class includes a virtual toString method
    /// By default toString returns the name of the type
    /// We may override toString to display their value
    /// Primitive types override toString to display their value
    /// Culture plays a large part in Format
    /// .Net provides mechanisms to control the format and culture during string Format
    /// </summary>
    public class FormatAsSrrings
    {
        public static string FormatPrice(CultureInfo culture, string format, decimal price)
        {
            return price.ToString(format, culture);
        }

        public static string FormatPercent(CultureInfo culture, double percent)
        {
            return percent.ToString("P", culture);
        }

        /// <summary>
        /// Converts a number to decimal digits, supported for integer values only
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <param name="precision">Precision, e.g. D8</param>
        public static string FormatIntegerToDecimalDigits(int number, int precision)
        {
            string percisionFormat = "D" + precision;
            return number.ToString(percisionFormat);
        }

        public static string FormatTemperature(double temperature)
        {
            return temperature.ToString("#.# 'degrees Celsius';#.# 'degrees Celsius below zero';#.#'Freezing'");
        }

        public static string FormatDateTime(DateTime dateTime, CultureInfo culture, string datePattern)
        {
            return dateTime.ToString(datePattern, culture);
        }

        public enum Status { Red = 1, Yellow = 2, Green = 3 };

        public static string FormatEnums(Status status, string pattern)
        {
            return status.ToString(pattern);
        }

        public static string FormatGuids(Guid guid, string pattern)
        {
            return guid.ToString(pattern);
        }
    }
}
