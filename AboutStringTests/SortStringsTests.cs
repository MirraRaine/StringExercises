using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Threading;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="SortStrings"/> class
    /// </summary>
    [TestClass]
    public class SortStringsTests
    {
        private readonly string[] inputArray = new string[]
            {
                "banana",
                "apple",
                "Lemon",
                "Apple",
                "grapes",
                "Banana",
                "lemon",
                "Grapes",
                ".grapes"
            };


        [TestMethod]
        public void SortStringsApplyingStringComparer_NoStringComparer_Test()
        {
            string[] expectedSortedOutput = new string[] { ".grapes", "apple", "Apple", "banana", "Banana", "grapes", "Grapes", "lemon", "Lemon" };
            string[] actualSortedOutput = SortStrings.SortStringsApplyingStringComparer(inputArray, null);
            for (int i = 0; i < expectedSortedOutput.Length - 1; i++)
            {
                Assert.AreEqual(expectedSortedOutput[i], actualSortedOutput[i]);
            }
        }

        [TestMethod]
        public void SortStringsApplyingStringComparer_StringComparer_Ordinal_Test()
        {
            StringComparer stringComparer = StringComparer.Ordinal;
            string[] expectedSortedOutput = new string[] { ".grapes", "Apple", "Banana", "Grapes", "Lemon", "apple", "banana", "grapes", "lemon" };
            string[] actualSortedOutput = SortStrings.SortStringsApplyingStringComparer(inputArray, stringComparer);
            for (int i = 0; i < expectedSortedOutput.Length - 1; i++)
            {
                Assert.AreEqual(expectedSortedOutput[i], actualSortedOutput[i]);
            }
        }

        [TestMethod]
        public void SortStringsApplyingStringComparer_StringComparer_OrdinalIgnoreCasel_Test()
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            string[] expectedSortedOutput = new string[] { ".grapes", "apple", "Apple", "banana", "Banana", "grapes", "Grapes", "Lemon", "lemon" };
            string[] actualSortedOutput = SortStrings.SortStringsApplyingStringComparer(inputArray, stringComparer);
            for (int i = 0; i < expectedSortedOutput.Length - 1; i++)
            {
                Assert.AreEqual(expectedSortedOutput[i], actualSortedOutput[i]);
            }
        }

        /// <summary>
        /// We still have alphabetical sort, the string with a period char now appears after lower case word grapes
        /// We chose to ignore symbols
        /// </summary>
        [TestMethod]
        public void SortStringsApplyingStringComparer_StringComparer_WithCulture_IgnoreSymbols_Test()
        {
            StringComparer stringComparer = StringComparer.Create(new CultureInfo("en-GB"), CompareOptions.IgnoreSymbols);
            string[] expectedSortedOutput = new string[] { "apple", "Apple", "banana", "Banana", "grapes", ".grapes", "Grapes", "lemon", "Lemon" };
            string[] actualSortedOutput = SortStrings.SortStringsApplyingStringComparer(inputArray, stringComparer);
            for (int i = 0; i < expectedSortedOutput.Length - 1; i++)
            {
                Assert.AreEqual(expectedSortedOutput[i], actualSortedOutput[i]);
            }
        }

        /// <summary>
        /// Default Culture
        /// da-DK comparer
        /// </summary>
        [TestMethod]
        public void SortStringsApplyingStringComparerWithCultureTest1()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            string[] input = new string[] { "brug", "æbler" };

            string[] expectedSortedOutput = new string[] { "æbler", "brug" };
            string[] actualSortedOutput = SortStrings.SortStringsApplyingStringComparerWithCulture(input, null, currentCulture);
            for (int i = 0; i < expectedSortedOutput.Length - 1; i++)
            {
                Assert.AreEqual(expectedSortedOutput[i], actualSortedOutput[i]);
            }
        }

        /// <summary>
        /// en-US culture
        /// da-DK comparer
        /// </summary>
        [TestMethod]
        public void SortStringsApplyingStringComparerWithCultureTest2()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture; // english culture
            StringComparer stringComparer = StringComparer.Create(new CultureInfo("da-DK"), CompareOptions.None); // danish comparer
            string[] input = new string[] { "brug", "æbler" };

            string[] expectedSortedOutput = new string[] { "brug", "æbler" };
            string[] actualSortedOutput = SortStrings.SortStringsApplyingStringComparerWithCulture(input, stringComparer, currentCulture);
            for (int i = 0; i < expectedSortedOutput.Length - 1; i++)
            {
                Assert.AreEqual(expectedSortedOutput[i], actualSortedOutput[i]);
            }
        }

        /// <summary>
        /// da-DK culture
        /// da-DK comparer
        /// </summary>
        [TestMethod]
        public void SortStringsApplyingStringComparerWithCultureTest3()
        {
            CultureInfo currentCulture = new CultureInfo("da-DK"); // danish culture
            StringComparer stringComparer = StringComparer.Create(new CultureInfo("da-DK"), CompareOptions.None); //danish comparer
            string[] input = new string[] { "brug", "æbler" };

            string[] expectedSortedOutput = new string[] { "brug", "æbler" };
            string[] actualSortedOutput = SortStrings.SortStringsApplyingStringComparerWithCulture(input, stringComparer, currentCulture);
            for (int i = 0; i < expectedSortedOutput.Length - 1; i++)
            {
                Assert.AreEqual(expectedSortedOutput[i], actualSortedOutput[i]);
            }
        }
    }
}
