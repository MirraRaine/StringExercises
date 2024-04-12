using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="SearchStrings"/> class
    /// </summary>
    [TestClass]
    public class SearchStringsTests
    {
        [TestMethod]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Dior", true)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", " ", true)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "'", true)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Chanel", false)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", null, false)]
        public void DoesStringContainTest(string data, string searchWord, bool containExpected)
        {
            bool containActual = SearchStrings.DoesStringContain(data, searchWord);
            Assert.AreEqual(containExpected, containActual);
        }

        [TestMethod]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "christian", true, StringComparison.OrdinalIgnoreCase)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "christian", false, StringComparison.Ordinal)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "christian", false, StringComparison.InvariantCulture)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Christian", true, StringComparison.Ordinal)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Christian", true, StringComparison.InvariantCulture)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Dior", false, StringComparison.OrdinalIgnoreCase)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Dior", false, StringComparison.Ordinal)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Dior", false, StringComparison.InvariantCulture)]
        public void DoesStringStartWithTest(string data, string searchWord, bool containExpected, StringComparison stringComparison)
        {
            bool containActual = SearchStrings.DoesStringStartWith(data, searchWord, stringComparison);
            Assert.AreEqual(containExpected, containActual);
        }

        [TestMethod]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", 'J', true)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", '\'', true)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", 'Y', false)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", '!', false)]
        public void DoesStringContainCharTest(string data, char searchCharacter, bool containExpected)
        {
            bool containActual = SearchStrings.DoesStringContainChar(data, searchCharacter);
            Assert.AreEqual(containExpected, containActual);
        }

        [TestMethod]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "dior", StringComparison.OrdinalIgnoreCase, 10)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "dior", StringComparison.Ordinal, -1)]
        public void GetIndexWithinStringTest(string data, string searchFor, StringComparison stringComparison, int expectedIndex)
        {
            int actualIndex = SearchStrings.GetIndexWithinString(data, searchFor, stringComparison);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "I", 0, 5, StringComparison.OrdinalIgnoreCase, 3)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "I", 4, 10, StringComparison.OrdinalIgnoreCase, 6)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "I", 0, 5, StringComparison.Ordinal, -1)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "I", 4, 10, StringComparison.Ordinal, -1)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Parfum", 0, 10, StringComparison.Ordinal, -1)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "Parfum", 29, 8, StringComparison.Ordinal, 30)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "parfum", 29, 8, StringComparison.Ordinal, -1)]
        [DataRow("Christian Dior J'Adore Eau De Parfum Spray", "parfum", 29, 8, StringComparison.OrdinalIgnoreCase, 30)]
        public void GetIndexWithinStringInGivenRangeTest(string data, string searchFor, int startAt, int countToExplore, StringComparison stringComparison, int expectedIndex)
        {
            int actualIndex = SearchStrings.GetIndexWithinStringInGivenRange(data, searchFor, startAt, countToExplore, stringComparison);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void GetIndexOfCharWithinStringTest()
        {
            string data = "Christian Dior J'Adore Eau De Parfum Spray, 100ml";
            char[] searchFor = new[] { '\'', ','};
            int expectedIndex = 16;
            int actualIndex = SearchStrings.GetIndexOfCharWithinString(data, searchFor);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [DataRow("Brand: Tom Ford, Fragrance: Lost Cherry", "^[A-Za-z]", true)]
        [DataRow("brand: Guerlain", "^[A-Za-z]", true)]
        [DataRow("Le Labo Santal 33, fragrance", "^[A-Za-z]", true)]
        [DataRow("1. chanel", "^[A-Za-z]", false)]
        [DataRow("Brand: Dior, Fragrance: Dune", ": (\\w+),", true)]
        [DataRow("Brand: Tom Ford, Fragrance: Lost Cherry", ": (\\w+),", false)]
        [DataRow("brand: Guerlain", ": (\\w+),", false)]
        [DataRow("Le Labo Santal 33, fragrance", ": (\\w+),", false)]
        [DataRow("1. chanel", ": (\\w+),", false)]
        [TestMethod]
        public void RegularExpressionTest(string data, string pattern, bool expectedMatch)
        {
            bool actualMatch = SearchStrings.DoesStringMatchAPattern(data, pattern);
            Assert.AreEqual(expectedMatch, actualMatch);
        }

        [DataRow("Brand: Mugler, Model: Angel", false)]
        [DataRow("fragrance: Bee", true)]
        [DataRow("Zoologist, Bee, fragrance", false)]
        [DataRow("1. fragrance", false)]
        [TestMethod]
        public void DoesStringContainCharsWithSpanTest(string data, bool expectedMatch)
        {

            char[] arrayOfCharacters = new char[] { 'f', 'r', 'a', 'g', 'r', 'a', 'n', 'c', 'e' };
            bool actualMatch = SearchStrings.DoesStringContainCharsWithSpan(data, arrayOfCharacters);
            Assert.AreEqual(expectedMatch, actualMatch);
        }
    }
}
