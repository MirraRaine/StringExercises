using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="EqualityStrings"/> class
    /// </summary>
    [TestClass]
    public class EqualityStringsTests
    {
        [TestMethod]
        [DataRow("Hello World!", "Hello World!", true, false)]
        [DataRow("Hello World!", "hello world!", false, false)]
        [DataRow(null, "Hello World!", true, true)]
        [DataRow("Hello World!", null, false, false)]
        public void CompareStringsWithEqualsTests(string str1, string str2, bool expectedEquals, bool expectedException)
        {
            bool actualException = false;
            try
            {
                bool actualEquals = EqualityStrings.CompareStringsWithEquals(str1, str2);
                Assert.AreEqual(expectedEquals, actualEquals);
            }
            catch (NullReferenceException ex)
            {
                actualException = true;
            }

            Assert.AreEqual(expectedException, actualException);
        }

        [TestMethod]
        [DataRow("Hello World!", "hello world!", false, false, true, false)]
        [DataRow("fussball", "fußball", false, false, false, false)]
        [DataRow("fussball", "fu\u00DFball", false, false, false, false)]
        public void CompareStringsWithEqualsAndStringComparisonTests(string str1, string str2, bool whenNoCulture, bool whenOrdinal, bool whenOrdinalIgnoreCase, bool whenCurrentCulture)
        {
            bool equals;

            // this is equivalent to the call with no provided culture
            equals = EqualityStrings.CompareStringsWithEqualsAndStringComparison(str1, str2, StringComparison.Ordinal);
            Assert.AreEqual(whenOrdinal, equals);

            equals = EqualityStrings.CompareStringsWithEqualsAndStringComparison(str1, str2, StringComparison.OrdinalIgnoreCase);
            Assert.AreEqual(whenOrdinalIgnoreCase, equals);

            equals = EqualityStrings.CompareStringsWithEqualsAndStringComparison(str1, str2, StringComparison.CurrentCulture);
            Assert.AreEqual(whenCurrentCulture, equals);
        }

        [TestMethod]
        public void ComareStringsWithCultureExampleTest()
        {
            bool pass = EqualityStrings.ComareStringsWithCultureExample();
            Assert.IsTrue(pass);
        }

        [TestMethod]
        [DataRow("Hello World!", "hello world!", false)]
        [DataRow("Hello World!", "Hello World!", true)]
        [DataRow("fussball", "fußball", false)]
        [DataRow("fussball", "fu\u00DFball", false)]
        [DataRow(" ", " ", true)]
        [DataRow(null, null, true)]
        [DataRow(null, "apple", false)]
        public void CompareStringsWithEqualityOperatorsTests(string str1, string str2, bool expectedEquals)
        {
            bool actualEquals = EqualityStrings.CompareStringsWithEqualityOperators(str1, str2);
            Assert.AreEqual(expectedEquals, actualEquals);
        }

        [TestMethod]
        [DataRow("apple", false)]
        [DataRow("---", false)]
        [DataRow(" ", false)]
        [DataRow("", true)]
        [DataRow(null, true)]
        public void IsNullOrEmptyTests(string str1, bool expectedIsNullOrEmpty)
        {
            bool actualIsNullOrEmpty = string.IsNullOrEmpty(str1);
            Assert.AreEqual(expectedIsNullOrEmpty, actualIsNullOrEmpty);
        }

        [TestMethod]
        [DataRow("apple", false)]
        [DataRow("---", false)]
        [DataRow(" ", true)]
        [DataRow("", true)]
        [DataRow(null, true)]
        public void IsNullOrWhiteSpaceTests(string str1, bool expectedIsNullOrEmpty)
        {
            bool actualIsNullOrEmpty = string.IsNullOrWhiteSpace(str1);
            Assert.AreEqual(expectedIsNullOrEmpty, actualIsNullOrEmpty);
        }
    }
}
