using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="ConcatenateAndFormatStrings"/> class
    /// </summary>
    [TestClass]
    public class ConcatenateAndFormatStringsTests
    {
        /// <summary>
        /// Test for 
        /// ConcatenateAndFormatStrings.ConcatenateWithOperatorsOpt1,
        /// ConcatenateAndFormatStrings.ConcatenateWithOperatorsOpt2,
        /// ConcatenateAndFormatStrings.ConcatenateWithOperatorsOpt3,
        /// </summary>
        [TestMethod]
        public void ConcatenateWithOperatorsTest()
        {
            string outputOpt1 = ConcatenateAndFormatStrings.ConcatenateWithOperatorsOpt1();
            Assert.AreEqual("Hello Mirra Raine", outputOpt1);

            string outputOpt2 = ConcatenateAndFormatStrings.ConcatenateWithOperatorsOpt2("Hello", "Mirra", "Raine");
            Assert.AreEqual("Hello Mirra Raine", outputOpt2);

            string outputOpt3 = ConcatenateAndFormatStrings.ConcatenateWithOperatorsOpt3("Hello", "Mirra", "Raine");
            Assert.AreEqual("Hello Mirra Raine", outputOpt2);
        }

        /// <summary>
        /// Test ConcatenateAndFormatStrings.CompositeFomatting
        /// </summary>
        [TestMethod]
        public void CompositeFomattingTest()
        {
            string output = ConcatenateAndFormatStrings.CompositeFomatting("Mirra", "Raine");
            Assert.AreEqual("Hello Mirra Raine", output);
        }

        /// <summary>
        /// Test ConcatenateAndFormatStrings.PriceCompositeFomattingWithCulture
        /// </summary>
        [TestMethod]
        [DataRow("en-US", "The price is $3,205.41")]
        [DataRow("de-DE", "The price is 3.205,41 €")]
        [DataRow("ja-JP", "The price is ￥3,205")]
        public void PriceCompositeFomattingWithCultureTest(string cultureStr, string expectedFormattedPrice)
        {
            CultureInfo culture = new CultureInfo(cultureStr);
            string inputPrice = "3205.41";
            string actualFormattedPrice = ConcatenateAndFormatStrings.PriceCompositeFomattingWithCulture(culture, inputPrice);
            Assert.AreEqual(expectedFormattedPrice, actualFormattedPrice);
        }

        /// <summary>
        /// Test ConcatenateAndFormatStrings.TemperatureCompositeFomattingWithCulture
        /// </summary>
        /// <param name="cultureStr"></param>
        /// <param name="expectedFormattedPrice"></param>
        [TestMethod]
        [DataRow("en-US", "At 2/21/2024, the temp is 13.99C")]
        [DataRow("de-DE", "At 21.02.2024, the temp is 13,99C")]
        [DataRow("ja-JP", "At 2024/02/21, the temp is 13.99C")]
        public void TemperatureCompositeFomattingWithCultureTest(string cultureStr, string expectedFormattedPrice)
        {
            CultureInfo culture = new CultureInfo(cultureStr);
            DateTime dateTime = new DateTime(2024, 02, 21);
            double temperature = 13.993548217226541;
            string actualFormattedPrice = ConcatenateAndFormatStrings.TemperatureCompositeFomattingWithCulture(culture, dateTime, temperature);
            Assert.AreEqual(expectedFormattedPrice, actualFormattedPrice);
        }

        /// <summary>
        /// Test for ConcatenateAndFormatStrings.TimeSpanCompositeFomatting
        /// </summary>
        [TestMethod]
        public void TimeSpanCompositeFomattingTests()
        {
            string name = "Damon Hill";
            TimeSpan time = new TimeSpan(0, 0, 1, 26, 875);
            string actualformattedMessage = ConcatenateAndFormatStrings.TimeSpanCompositeFomatting(name, time);
            string expectedFormattedMessage = "Driver is Damon Hill          . Lap Time is  01s26.875";
            Assert.AreEqual(expectedFormattedMessage, actualformattedMessage);

            name = "Jackues Villeneuve";
            time = new TimeSpan(0, 0, 1, 27, 070);
            actualformattedMessage = ConcatenateAndFormatStrings.TimeSpanCompositeFomatting(name, time);
            expectedFormattedMessage = "Driver is Jackues Villeneuve  . Lap Time is  01s27.070";
            Assert.AreEqual(expectedFormattedMessage, actualformattedMessage);

            name = "Michael Schumacher";
            time = new TimeSpan(0, 0, 1, 27, 707);
            actualformattedMessage = ConcatenateAndFormatStrings.TimeSpanCompositeFomatting(name, time);
            expectedFormattedMessage = "Driver is Michael Schumacher  . Lap Time is  01s27.707";
            Assert.AreEqual(expectedFormattedMessage, actualformattedMessage);
        }

        /// <summary>
        /// Test for 
        /// ConcatenateAndFormatStrings.ConcatStringsWithPlusOperator
        /// ConcatenateAndFormatStrings.ConcatStringsWithConcatFunc
        /// ConcatenateAndFormatStrings.ConcatStringsWithJoinFunc
        /// </summary>
        [TestMethod]
        public void StringConcatenationAndJoinTests()
        {
            string[] words = { "My", "name", "is", "Mirra", "Raine" };
            string actualFinalSentence = ConcatenateAndFormatStrings.ConcatStringsWithPlusOperator(words);
            string expectedFinalSentence = "MynameisMirraRaine";
            Assert.AreEqual(actualFinalSentence, expectedFinalSentence);

            actualFinalSentence = ConcatenateAndFormatStrings.ConcatStringsWithConcatFunc(words);
            expectedFinalSentence = "MynameisMirraRaine";
            Assert.AreEqual(actualFinalSentence, expectedFinalSentence);

            actualFinalSentence = ConcatenateAndFormatStrings.ConcatStringsWithJoinFunc(words);
            expectedFinalSentence = "My name is Mirra Raine";
            Assert.AreEqual(actualFinalSentence, expectedFinalSentence);
        }

        /// <summary>
        /// Test for ConcatenateAndFormatStrings.StringInsertGreeting
        /// </summary>
        [TestMethod]
        public void StringInsertGreetingTest()
        {
            string greeting = "Welcome Sun";
            string actualFinalSentence = ConcatenateAndFormatStrings.StringInsertGreeting(greeting);
            string expectedFinalSentence = "Your greeting is: Welcome Sun!";
            Assert.AreEqual(actualFinalSentence, expectedFinalSentence);
        }

        /// <summary>
        /// Test for ConcatenateAndFormatStrings.StringInterpolation
        /// </summary>
        [TestMethod]
        [DataRow("en-US", 15.993548217226541, "At 3/10/2024 the temperature is 15.99C")]
        [DataRow("de-DE", 18.993548217226541, "At 10.03.2024 the temperature is 18,99C")]
        [DataRow("ja-JP", 23.993548217226541, "At 2024/03/10 the temperature is 23.99C")]
        public void StringInterpolationTest(string cultureStr, double temperature, string expectedWeather)
        {
            CultureInfo culture = new CultureInfo(cultureStr);
            DateTime dateTime = new DateTime(2024, 03, 10);

            string actualWeather = ConcatenateAndFormatStrings.StringInterpolation(culture, temperature, dateTime);
            Assert.AreEqual(expectedWeather, actualWeather);
        }

        /// <summary>
        /// Test for ConcatenateAndFormatStrings.StringBuilderPoem
        /// </summary>
        [TestMethod]
        public void StringBuilderPoemTest()
        {
            DateTime dateTime = new DateTime(1609);
            IEnumerable<string> data = GetPoem();
            string author = "WILLIAM SHAKESPEARE";

            string actualMessage = ConcatenateAndFormatStrings.StringBuilderPoem(data, dateTime, author);
            string expectedMessage = "Shall I compare thee to a summer’s day?Thou art more lovely and more temperate:Rough winds do shake the darling buds of May,And summer’s lease hath all too short a date;Author WILLIAM SHAKESPEARE.Written in 1/1/0001 12:00:00 AM";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        /// <summary>
        /// Test for 
        /// ConcatenateAndFormatStrings.StringBuilderOptimizedCreation
        /// ConcatenateAndFormatStrings.StringBuilderOptimizedCreationWithEnsuredCapacity
        /// ConcatenateAndFormatStrings.StringBuilderInsufficientCapacity
        /// </summary>
        [TestMethod]
        public void StringBuilderOptimizedCreationTests()
        {
            string str = "This is a string. ";
            int iterateCounter = 10;
            (int actualLength, int actualCapacity, string actualString) = ConcatenateAndFormatStrings.StringBuilderOptimizedCreation(str, iterateCounter);

            int expectedLength = 198;
            int expectedCapacity = 198;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(expectedCapacity, actualCapacity);

            iterateCounter = 30;
            (actualLength, actualCapacity) = ConcatenateAndFormatStrings.StringBuilderOptimizedCreationWithEnsuredCapacity(actualString, iterateCounter);
            expectedLength = 6138;
            expectedCapacity = 6138;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(expectedCapacity, actualCapacity);

            try
            {
                string finalString = ConcatenateAndFormatStrings.StringBuilderInsufficientCapacity(str);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("The length cannot be greater than the capacity. (Parameter 'valueCount')", ex.Message);
            }
        }

        /// <summary>
        /// Test for ConcatenateAndFormatStrings.PoolingStringBuilders
        /// </summary>
        [TestMethod]
        public void PoolingStringBuildersTest()
        {
            string str = "Some Text!";
            string actualMessage = ConcatenateAndFormatStrings.PoolingStringBuilders(str);
            Assert.AreEqual(str, actualMessage);
        }

        /// <summary>
        /// Test for ConcatenateAndFormatStrings.StringBuilderReplace
        /// </summary>
        [TestMethod]
        public void StringBuilderReplaceTest()
        {
            string str = "shall make no law respecting an establishment of religion| " +
                "or prohibiting the free exercise thereof; or abridging the freedom of speech| or of the press; " +
                "or the right of the people peaceably to assemble| " +
                "and to petition the Government for a redress of grievances.";
            string start = "Congress";

            string expectedMessage = "Congress shall make no law respecting an establishment of religion, or prohibiting the free exercise thereof; or abridging the freedom of speech, or of the press; or the right of the people peaceably to assemble, and to petition the Government for a redress of grievances.";
            string actualMessage = ConcatenateAndFormatStrings.StringBuilderReplace(str, start, '|', ',');
            Assert.AreEqual(expectedMessage, actualMessage);
        }
        private static IEnumerable<string> GetPoem()
        {
            return new List<string>
            {
                "Shall I compare thee to a summer’s day?",
                "Thou art more lovely and more temperate:",
                "Rough winds do shake the darling buds of May,",
                "And summer’s lease hath all too short a date;"
            };
        }
    }
}
