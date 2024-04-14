using System;
using System.Globalization;

namespace AboutString
{
    /// <summary>
    /// This class represents different operations to parse string into another .NET types
    /// </summary>
    public class ParseStrings
    {
        public static int ParseToInt32(string input)
        {
            return Convert.ToInt32(input);
        }

        public static int ParseWithIntParse(string input)
        {
            try
            {
                int intNumber = int.Parse(input);
                return intNumber;
            }
            catch (FormatException ex)
            {
                throw new FormatException("Custom: Input string is not valid for conversation to an integer", ex);
            }
            catch (OverflowException ex)
            {
                throw new OverflowException("Custom: The number is too large for conversion to an integer", ex);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Custom: Value cannot be null", ex);
            }
        }

        public static (bool, int) ParseWithIntTryParse(string input)
        {
            bool isSuccesfullyParsed = int.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out int theNumber);
            return (isSuccesfullyParsed, theNumber);
        }

        public static (bool, double) ParseWithDoubleTryParse(string input)
        {
            bool isSuccesfullyParsed = double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out double theNumber);
            return (isSuccesfullyParsed, theNumber);
        }

        public static bool ParseWithBooleanParser(string input)
        {
            try
            {
                bool boolValue = bool.Parse(input);
                return boolValue;
            }
            catch (FormatException ex)
            {
                throw new FormatException("Custom: Input string is not valid for conversation to a boolean", ex);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Custom: Value cannot be null", ex);
            }
        }

        public static (bool, bool) ParseWithBooleanTryParse(string input)
        {
            bool isSuccesfullyParsed = bool.TryParse(input, out bool theBoolean);
            return (isSuccesfullyParsed, theBoolean);
        }

        public static (bool, DateTime) ParseDateAndTimeTryParse(CultureInfo culture, string date)
        {
            bool isSuccesfullyParsed = DateTime.TryParse(date, culture, DateTimeStyles.AdjustToUniversal, out DateTime parsedDateTime);
            return (isSuccesfullyParsed, parsedDateTime);
        }

        public static (bool, DateTimeOffset) ParseDateTimeOffsetPlusNDays(CultureInfo culture, string date, int nDaysToAdd)
        {
            bool isSuccesfullyParsed = DateTimeOffset.TryParseExact(date, "o", culture, DateTimeStyles.None, out DateTimeOffset parsedDatetImeOffset);
            parsedDatetImeOffset = parsedDatetImeOffset.AddDays(nDaysToAdd);
            return (isSuccesfullyParsed, parsedDatetImeOffset);
        }

        public static (bool, DayOfWeek) ParseWithEnumTryParse(string input)
        {
            bool isSuccesfullyParsed = Enum.TryParse(input, true, out DayOfWeek dayOfWeek);
            return (isSuccesfullyParsed, dayOfWeek);
        }

        public static (bool, char) ParseWithCharTryParse(string input)
        {
            bool isSuccesfullyParsed = char.TryParse(input, out char character);
            return (isSuccesfullyParsed, character);
        }
    }
}
