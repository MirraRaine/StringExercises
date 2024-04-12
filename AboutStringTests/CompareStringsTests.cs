using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="CompareStrings"/> class
    /// </summary>
    [TestClass]
    public class CompareStringsTests
    {
        /// <summary>
        /// Test for CompareStrings.CompareWithCurrentCulture
        /// </summary>
        [TestMethod]
        [DataRow("HELLO", "hello", 1, "English (United States)")] // 1 - HELLO string is sorted after the lowercase version
        [DataRow("hello", "HELLO", -1, "English (United States)")] // -1 - the order of the strings is switched around in comparison
        [DataRow("HELLO", "HELLO", 0, "English (United States)")] // 0 - strings are equal
        [DataRow("HELLO", null, 1, "English (United States)")]
        public void CompareHelloDifferentCaseTest(string inputOne, string inputTwo, int expectedComparison, string expectedCulture)
        {
            (int comparison, string culture) = CompareStrings.CompareWithCurrentCulture(inputOne, inputTwo);
            Assert.AreEqual(expectedComparison, comparison);
            Assert.AreEqual(expectedCulture, culture);
        }

        /// <summary>
        /// Test for CompareStrings.CompareWithStringOrdinal
        /// The difference in the unicode values is offset by 32
        /// </summary>
        [TestMethod]
        [DataRow("hello", "HELLO", 32)]
        [DataRow("HELLO", "hello", -32)] // -32 HELLO precedes the lowercase version, because upper case letter go first on unicode table
        [DataRow("HELLO", null, 1)]
        [DataRow(null, "HELLO", -1)]
        [DataRow(null, null, 0)]
        public void CompareWithStringOrdinalTest(string inputOne, string inputTwo, int expectedComparison)
        {
            int actualComparison = CompareStrings.CompareWithStringOrdinal(inputOne, inputTwo);
            Assert.AreEqual(expectedComparison, actualComparison);
        }

        /// <summary>
        /// Tests for CompareStrings.CompareWithStringComparison
        /// 0 indicates that the strings are equal.
        /// highen may be treated with special rules in some cultures and affect how strings are sorted
        /// </summary>
        [TestMethod]
        [DataRow("hello", "HELLO", StringComparison.OrdinalIgnoreCase, 0)] // when the case of the string us ignored, 2 strings are considered equivalent
        [DataRow("co-operate", "cooperate", StringComparison.CurrentCulture, -1)] // the first string preceeds the second because of the highen
        [DataRow("co-operate", "cumulative", StringComparison.CurrentCulture, -1)] // the first string preceeds the second because of the highen 
        [DataRow("co-operate", "code", StringComparison.CurrentCulture, -1)] // the first string preceeds the second because of the highen 
        [DataRow("co-operate", "cooperate", StringComparison.Ordinal, -66)] // 45(=highen decimal unit) - 111(lower case latter o) = -66
        [DataRow("co-operate", "cumulative", StringComparison.Ordinal, -6)]
        [DataRow("co-operate", "code", StringComparison.Ordinal, -55)]
        public void CompareWithStringComparisonTest(string inputOne, string inputTwo, StringComparison stringComparison, int expectedComparison)
        {
            int actualComparison = CompareStrings.CompareWithStringComparison(inputOne, inputTwo, stringComparison);
            Assert.AreEqual(expectedComparison, actualComparison);
        }
    }
}
