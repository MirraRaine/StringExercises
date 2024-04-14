using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using static AboutString.FormatAsStrings;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="FormatAsStrings"/> class
    /// </summary>
    [TestClass]
    public class FormatAsSrringsTests
    {
        /// <summary>
        /// The method tests FormatAsSrrings.FormatPrice
        /// </summary>
        /// <param name="cultureName">Culture to apply during Format</param>
        /// <param name="format">Format to use on a numeric value
        ///  <list type="bullet">
        /// <item>
        /// <description>C - currency representation of a numeric value</description>
        /// </item>
        /// <item>
        /// <description>F - fixed-point format with number of decimal places we require (3).</description>
        /// </item>
        /// <item>
        /// <description>N1 - numeric format that includes a group separator between groups of digits, 1 - expect a single digit after a decimal place</description>
        /// </item>
        /// </list>
        /// </param>
        /// <param name="expectedFormattedPrice">Expected formatted output</param>
        [TestMethod]
        [DataRow("en-US", "C", "$2,379.18")]
        [DataRow("en-US", "F3", "2379.185")]
        [DataRow("en-US", "N1", "2,379.2")]
        [DataRow("de-DE", "C", "2.379,18 €")]
        [DataRow("de-DE", "F3", "2379,185")]
        [DataRow("de-DE", "N1", "2.379,2")]
        [DataRow("ja-JP", "C", "￥2,379")]
        [DataRow("ja-JP", "F3", "2379.185")]
        [DataRow("ja-JP", "N1", "2,379.2")]
        public void FormatPriceTests(string cultureName, string format, string expectedFormattedPrice)
        {
            decimal price = 2379.18469m;

            CultureInfo culture = new CultureInfo(cultureName);
            string actualFormattedPrice = FormatAsStrings.FormatPrice(culture, format, price);
            Assert.AreEqual(expectedFormattedPrice, actualFormattedPrice);
        }

        [TestMethod]
        [DataRow("en-US", .783578, "78.36%")]
        [DataRow("en-US", 1.7, "170.00%")]
        [DataRow("en-US", 0.005, "0.50%")]
        [DataRow("en-US", .05, "5.00%")]
        [DataRow("en-US", 1.7, "170.00%")]
        [DataRow("de-DE", .783578, "78,358 %")]
        [DataRow("de-DE", 1.7, "170,000 %")]
        [DataRow("de-DE", 0.005, "0,500 %")]
        [DataRow("de-DE", .05, "5,000 %")]
        [DataRow("de-DE", 1.7, "170,000 %")]
        [DataRow("ja-JP", .783578, "78.358%")]
        [DataRow("ja-JP", 1.7, "170.000%")]
        [DataRow("ja-JP", 0.005, "0.500%")]
        [DataRow("ja-JP", .05, "5.000%")]
        [DataRow("ja-JP", 1.7, "170.000%")]
        public void FormatPercentTests(string cultureName, double percent, string expectedFormattedPercent)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            string actualFormattedPercent = FormatAsStrings.FormatPercent(culture, percent);
            Assert.AreEqual(expectedFormattedPercent, actualFormattedPercent);
        }

        [TestMethod]
        [DataRow(15988, 8, "00015988")]
        [DataRow(15988, 3, "15988")]
        public void FormatIntegerToDecimalDigitsTests(int number, int precision, string expectedFormattedNum)
        {
            string actualFormattedNum = FormatAsStrings.FormatIntegerToDecimalDigits(number, precision);
            Assert.AreEqual(expectedFormattedNum, actualFormattedNum);
        }

        [TestMethod]
        [DataRow(31.25, "31.3 degrees Celsius")]
        [DataRow(-5.1, "5.1 degrees Celsius below zero")]
        [DataRow(0.0, "Freezing")]
        [DataRow(0.1, ".1 degrees Celsius")]
        [DataRow(-75.237, "75.2 degrees Celsius below zero")]
        public void FormatTemperatureTests(double temperature, string expectedWeather)
        {
            string actualWeather = FormatAsStrings.FormatTemperature(temperature);
            Assert.AreEqual(expectedWeather, actualWeather);
        }

        [TestMethod]
        [DataRow("en-US", "", "3/2/2024 7:39:17 AM")]
        [DataRow("en-US", "d", "3/2/2024")] // short date pattern
        [DataRow("en-US", "D", "Saturday, March 2, 2024")]
        [DataRow("en-US", "F", "Saturday, March 2, 2024 7:39:17 AM")] // full date time pattern
        [DataRow("en-US", "o", "2024-03-02T07:39:17.0000000")]  // roundtrip format, consistent across cultures
        [DataRow("en-US", "dddd, d MMMM yyyy 'at' hh:mm tt", "Saturday, 2 March 2024 at 07:39 AM")] // custom format
        [DataRow("de-DE", "", "02.03.2024 07:39:17")]
        [DataRow("de-DE", "d", "02.03.2024")]
        [DataRow("de-DE", "D", "Samstag, 2. März 2024")]
        [DataRow("de-DE", "F", "Samstag, 2. März 2024 07:39:17")]
        [DataRow("de-DE", "o", "2024-03-02T07:39:17.0000000")]
        [DataRow("de-DE", "dddd, d MMMM yyyy 'at' hh:mm tt", "Samstag, 2 März 2024 at 07:39 AM")]
        [DataRow("ja-JP", "", "2024/03/02 7:39:17")]
        [DataRow("ja-JP", "d", "2024/03/02")]
        [DataRow("ja-JP", "D", "2024年3月2日土曜日")]
        [DataRow("ja-JP", "F", "2024年3月2日土曜日 7:39:17")]
        [DataRow("ja-JP", "o", "2024-03-02T07:39:17.0000000")]
        [DataRow("ja-JP", "dddd, d MMMM yyyy 'at' hh:mm tt", "土曜日, 2 3月 2024 at 07:39 午前")]
        public void FormatDateTimeTests(string cultureName, string pattern, string expectedFormattedDateTime)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            DateTime dateTime = new DateTime(2024, 03, 02, 07, 39, 17);
            string actualFormattedDateTime = FormatAsStrings.FormatDateTime(dateTime, culture, pattern);
            Assert.AreEqual(expectedFormattedDateTime, actualFormattedDateTime);
        }

        [TestMethod]
        [DataRow("", "Yellow")] // enum general format
        [DataRow("G", "Yellow")] // enum general format - option G
        [DataRow("D", "2")] // enum entry integer value
        public void FormatEnumsTests(string pattern, string expectedFormattedEnum)
        {
            Status status = Status.Yellow;
            string actualFormattedEnum = FormatAsStrings.FormatEnums(status, pattern);
            Assert.AreEqual(expectedFormattedEnum, actualFormattedEnum);
        }

        [TestMethod]
        [DataRow("", "12345678-1111-2222-3333-012345678901")] // 32 digits separated by highens
        [DataRow("D", "12345678-1111-2222-3333-012345678901")] // default format  32 digits separated by highens (option D)
        [DataRow("N", "12345678111122223333012345678901")] // 32 digits with no highens
        [DataRow("B", "{12345678-1111-2222-3333-012345678901}")]  // includes highens and enclose the value in braces
        [DataRow("P", "(12345678-1111-2222-3333-012345678901)")] // includes highens and enclose the value in parenthesis
        public void FormatGuidsTests(string pattern, string expectedGuid)
        {
            Guid guid = new Guid("12345678-1111-2222-3333-012345678901");
            string actualGuid = FormatAsStrings.FormatGuids(guid, pattern);
            Assert.AreEqual(expectedGuid, actualGuid);
        }
    }
}
