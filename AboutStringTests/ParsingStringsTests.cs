using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="ParsingStrings"/> class
    /// </summary>
    [TestClass]
    public class ParsingStringsTests
    {
        [TestMethod]
        public void ParseIntSuccessfullyTest()
        {
            const string number = "123456";
            int intNumber = ParsingStrings.ParseToInt32(number);
            Assert.AreEqual(123456, intNumber);

            intNumber = ParsingStrings.ParseWithIntParse(number);
            Assert.AreEqual(123456, intNumber);
        }

        [TestMethod]
        [DataRow("15.90")]
        [DataRow("-3,105")]
        [DataRow("This is not a number!")]
        [DataRow(" ")]
        public void ParseWithIntParseValidateFormatExceptionTest(string input)
        {
            try
            {
                int intNumber = ParsingStrings.ParseWithIntParse(input);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is FormatException);
                Assert.AreEqual(ex.Message, "Custom: Input string is not valid for conversation to an integer");
            }
        }

        [TestMethod]
        [DataRow("1234567890123456789")]
        public void ParseWithIntParseValidateOverflowExceptionTest(string input)
        {
            try
            {
                int intNumber = ParsingStrings.ParseWithIntParse(input);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is OverflowException);
                Assert.AreEqual(ex.Message, "Custom: The number is too large for conversion to an integer");
            }
        }

        [TestMethod]
        [DataRow(null)]
        public void ParseWithIntParseValidateArgumentNullExceptionTest(string input)
        {
            try
            {
                int intNumber = ParsingStrings.ParseWithIntParse(input);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
                Assert.AreEqual(ex.Message, "Custom: Value cannot be null");
            }
        }

        [TestMethod]
        [DataRow("123456", true, 123456)]
        [DataRow("101", true, 101)]
        [DataRow("15.90", false, 0)]
        [DataRow("-3,105", true, -3105)]
        [DataRow("-3.105", false, 0)]
        [DataRow("This is not a number!", false, 0)]
        [DataRow("1234567890123456789", false, 0)]
        [DataRow(" ", false, 0)]
        [DataRow(null, false, 0)]
        public void ParseWithTryParseTest(string input, bool expectedIsSuccesfullyParsed, int expectedNumber)
        {
            (bool actualIsSuccesfullyParsed, int actualNumber) = ParsingStrings.ParseWithIntTryParse(input);

            Assert.AreEqual(expectedIsSuccesfullyParsed, actualIsSuccesfullyParsed);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [DataRow("123456", true, 123456)]
        [DataRow("101", true, 101)]
        [DataRow("15.90", true, 15.90)]
        [DataRow("-3,105", true, -3105)]
        [DataRow("-3.105", true, -3.105)]
        [DataRow("This is not a number!", false, 0)]
        [DataRow("1234567890123456789", true, 1234567890123456789)]
        [DataRow("1.7976931348623157E+308", true, 1.7976931348623157E+308)]
        [DataRow(" ", false, 0)]
        [DataRow(null, false, 0)]
        public void ParseWithDoubleTryParseTest(string input, bool expectedIsSuccesfullyParsed, double expectedNumber)
        {
            (bool actualIsSuccesfullyParsed, double actualNumber) = ParsingStrings.ParseWithDoubleTryParse(input);
            Assert.AreEqual(expectedIsSuccesfullyParsed, actualIsSuccesfullyParsed);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [DataRow("true", true)]
        [DataRow("false", false)]
        [DataRow("True", true)]
        [DataRow("False", false)]
        public void ParseWithBooleanParserTest(string input, bool expectedBool)
        {
            bool boolValue = ParsingStrings.ParseWithBooleanParser(input);
            Assert.AreEqual(expectedBool, boolValue);
        }

        [TestMethod]
        [DataRow(null)]
        public void ParseWithBooleanValidateArgumentNullExceptionTest(string input)
        {
            try
            {
                bool boolValue = ParsingStrings.ParseWithBooleanParser(input);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
                Assert.AreEqual(ex.Message, "Custom: Value cannot be null");
            }
        }

        [TestMethod]
        [DataRow("Not true")]
        [DataRow("!true")]
        [DataRow("yes")]
        [DataRow("no")]
        public void ParseWithBooleanValidateFormatExceptionTest(string input)
        {
            try
            {
                bool boolValue = ParsingStrings.ParseWithBooleanParser(input);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is FormatException);
                Assert.AreEqual(ex.Message, "Custom: Input string is not valid for conversation to a boolean");
            }
        }

        [TestMethod]
        [DataRow("true", true, true)]
        [DataRow("false", true, false)]
        [DataRow("True", true, true)]
        [DataRow("False", true, false)]
        [DataRow("Not true", false, false)]
        [DataRow("!true", false, false)]
        [DataRow(null, false, false)]
        [DataRow("yes", false, false)]
        [DataRow(" ", false, false)]
        public void ParseWithBooleanTryParseTest(string input, bool expectedIsSuccesfullyParsed, bool expectedBoolean)
        {
            (bool actualIsSuccesfullyParsed, bool actualBoolean) = ParsingStrings.ParseWithBooleanTryParse(input);

            Assert.AreEqual(expectedIsSuccesfullyParsed, actualIsSuccesfullyParsed);
            Assert.AreEqual(expectedBoolean, actualBoolean);
        }

        [TestMethod]
        [DataRow("en-US", "2024-06-05T12:30:00.0000000+02:00", true, "Wednesday, June 5, 2024 10:30:00 AM")]
        [DataRow("de-DE", "2024-06-05T12:30:00.0000000+02:00", true, "Wednesday, June 5, 2024 10:30:00 AM")]
        [DataRow("ja-JP", "2024-06-05T12:30:00.0000000+02:00", true, "Wednesday, June 5, 2024 10:30:00 AM")]

        [DataRow("en-US", "05/06/2020", true, "Wednesday, May 6, 2020 12:00:00 AM")]
        [DataRow("de-DE", "05/06/2020", true, "Friday, June 5, 2020 12:00:00 AM")]
        [DataRow("ja-JP", "05/06/2020", true, "Wednesday, May 6, 2020 12:00:00 AM")]

        [DataRow("en-US", "January 17, 2024", true, "Wednesday, January 17, 2024 12:00:00 AM")]
        [DataRow("de-DE", "January 17, 2024", true, "Wednesday, January 17, 2024 12:00:00 AM")]
        [DataRow("ja-JP", "January 17, 2024", true, "Wednesday, January 17, 2024 12:00:00 AM")]

        [DataRow("en-US", "April 2023", true, "Saturday, April 1, 2023 12:00:00 AM")]
        [DataRow("de-DE", "April 2023", true, "Saturday, April 1, 2023 12:00:00 AM")]
        [DataRow("ja-JP", "April 2023", true, "Saturday, April 1, 2023 12:00:00 AM")]

        [DataRow("en-US", "Mach 2018", false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("de-DE", "Mach 2018", false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("ja-JP", "Mach 2018", false, "Monday, January 1, 0001 12:00:00 AM")]

        [DataRow("en-US", "15-11-2020 10:30 AM", false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("de-DE", "15-11-2020 10:30 AM", true, "Sunday, November 15, 2020 10:30:00 AM")]
        [DataRow("ja-JP", "15-11-2020 10:30 AM", false, "Monday, January 1, 0001 12:00:00 AM")]

        [DataRow("en-US", null, false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("de-DE", null, false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("ja-JP", null, false, "Monday, January 1, 0001 12:00:00 AM")]

        public void ParseDateAndTimeTryParseTest(string cultureName, string input, bool expectedIsSuccesfullyParsed, string expectedDateTime)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            (bool actualIsSuccesfullyParsed, DateTime outputDateTime) = ParsingStrings.ParseDateAndTimeTryParse(culture, input);

            string actualDateTime = $"{outputDateTime:F}";
            Assert.AreEqual(expectedIsSuccesfullyParsed, actualIsSuccesfullyParsed);
            Assert.AreEqual(expectedDateTime, actualDateTime);
        }

        [TestMethod]
        [DataRow("2024-06-05T12:30:00.0000000+02:00", 0, true, "Wednesday, June 5, 2024 12:30:00 PM")]
        [DataRow("2024-06-05T12:30:00.0000000+02:00", 10, true, "Saturday, June 15, 2024 12:30:00 PM")]
        [DataRow("2023-08-30T12:30:00.0000000+03:00", 0, true, "Wednesday, August 30, 2023 12:30:00 PM")]
        [DataRow("2023-08-30T12:30:00.0000000+03:00", 5, true, "Monday, September 4, 2023 12:30:00 PM")]
        [DataRow("05/06/2020", 0, false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("January 17, 2024", 0, false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("April 2023", 0, false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("Mach 2018", 0, false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow("15-11-2020 10:30 AM", 0, false, "Monday, January 1, 0001 12:00:00 AM")]
        [DataRow(null, 0, false, "Monday, January 1, 0001 12:00:00 AM")]
        public void ParseDateTimeOffsetPlusNDaysTest(string input, int daysToAdd, bool expectedIsSuccesfullyParsed, string expectedDateTime)
        {
            CultureInfo culture = new CultureInfo("en-US");
            (bool actualIsSuccesfullyParsed, DateTimeOffset outputDateTime) = ParsingStrings.ParseDateTimeOffsetPlusNDays(culture, input, daysToAdd);

            string actualDateTime = $"{outputDateTime:F}";
            Assert.AreEqual(expectedIsSuccesfullyParsed, actualIsSuccesfullyParsed);
            Assert.AreEqual(expectedDateTime, actualDateTime);
        }

        [TestMethod]
        [DataRow("Monday", true, DayOfWeek.Monday)]
        [DataRow("SATURDAY", true, DayOfWeek.Saturday)]
        [DataRow("ThUrSdAy", true, DayOfWeek.Thursday)]
        [DataRow(" Monday", true, DayOfWeek.Monday)]
        [DataRow("November", false, DayOfWeek.Sunday)] // Sunday is default in case of failures
        [DataRow(null, false, DayOfWeek.Sunday)] // Sunday is default in case of failures
        public void ParseWithEnumTryParseTest(string input, bool expectedIsSuccesfullyParsed, DayOfWeek expectedDay)
        {
            (bool actualIsSuccesfullyParsed, DayOfWeek actualDay) = ParsingStrings.ParseWithEnumTryParse(input);
            Assert.AreEqual(expectedIsSuccesfullyParsed, actualIsSuccesfullyParsed);
            Assert.AreEqual(expectedDay, actualDay);
        }

        [TestMethod]
        [DataRow("A", true, 'A')]
        [DataRow("b", true, 'b')]
        [DataRow("\u006A", true, 'j')]
        [DataRow("🤔", false, '\0')]
        [DataRow("word", false, '\0')]
        public void ParseWithCharTryParseTest(string input, bool expectedIsSuccesfullyParsed, char expectedCharacter)
        {
            (bool actualIsSuccesfullyParsed, char actualCharacter) = ParsingStrings.ParseWithCharTryParse(input);
            Assert.AreEqual(expectedIsSuccesfullyParsed, actualIsSuccesfullyParsed);
            Assert.AreEqual(expectedCharacter, actualCharacter);
        }
    }
}