using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="EncodingStrings"/> class
    /// </summary>
    [TestClass]
    public class EncodingStringsTests
    {
        [TestMethod]
        [DataRow("", 0)]
        [DataRow(" ", 1)]
        [DataRow("a", 1)]
        [DataRow("\"", 1)]
        [DataRow("😀", 2)] // should be length 2 because it is represented with 2 chars that build a surrogate pair
        public void GetStringLengthTests(string str, int expectedLength)
        {
            int actualLength = EncodingStrings.GetStringLength(str);
            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void GetLengthAndTextElementsTests()
        {
            string emoji = " ";
            int actualTextElements = EncodingStrings.GetLengthInTextElements(emoji);
            int actualLength = EncodingStrings.GetStringLength(emoji);
            Assert.AreEqual(1, actualTextElements);
            Assert.AreEqual(1, actualLength);

            // should be length 2 because it is represented with 2 chars that build a surrogate pair
            emoji = "😀";
            actualTextElements = EncodingStrings.GetLengthInTextElements(emoji);
            actualLength = EncodingStrings.GetStringLength(emoji);
            Assert.AreEqual(1, actualTextElements);
            Assert.AreEqual(2, actualLength);

            // should be length 12 because each element is represented with 2 chars that build a surrogate pair
            emoji = "👶👶👶👶🍼🍼";
            actualTextElements = EncodingStrings.GetLengthInTextElements(emoji);
            actualLength = EncodingStrings.GetStringLength(emoji);
            Assert.AreEqual(6, actualTextElements);
            Assert.AreEqual(12, actualLength);

            emoji = Char.ConvertFromUtf32(Convert.ToInt32("1F600", 16));
            actualTextElements = EncodingStrings.GetLengthInTextElements(emoji);
            actualLength = EncodingStrings.GetStringLength(emoji);
            Assert.AreEqual(1, actualTextElements);
            Assert.AreEqual(2, actualLength);
        }

        [TestMethod]
        public void Utf8VsAsciiEncodingTests()
        {
            string input = "Some text that includes an emoji 🤔 that is represented by U+1F914."; // after decoding ascii will not be able to represent emoji because it does not know how to deal with them, will be replaced with question marks
            (int byteCount, string decodedString) = EncodingStrings.AsciiEncoding(input);
            string outputExpectedAscii = "Some text that includes an emoji ?? that is represented by U+1F914.";
            Assert.AreEqual(67, byteCount);
            Assert.AreEqual(outputExpectedAscii, decodedString);

            (byteCount, decodedString) = EncodingStrings.Utf8Encoding(input);
            string outputExpectedUtf8 = input;
            Assert.AreEqual(69, byteCount); // the emoji is represented with 2 chars, UTF8 undarstands it
            Assert.AreEqual(outputExpectedUtf8, decodedString);
        }

        [TestMethod]
        public void GraphemeCluster()
        {
            string emoji = " ";
            (int actualCounter, int actualTextElements) = EncodingStrings.GraphemeCluster(emoji);
            Assert.AreEqual(1, actualTextElements);
            Assert.AreEqual(1, actualCounter);

            emoji = "😀";
            (actualCounter, actualTextElements) = EncodingStrings.GraphemeCluster(emoji);
            Assert.AreEqual(1, actualTextElements);
            Assert.AreEqual(2, actualCounter);

            emoji = "👶👶👶👶🍼🍼";
            (actualCounter, actualTextElements) = EncodingStrings.GraphemeCluster(emoji);
            Assert.AreEqual(6, actualTextElements);
            Assert.AreEqual(12, actualCounter);

            emoji = Char.ConvertFromUtf32(Convert.ToInt32("1F600", 16));
            (actualCounter, actualTextElements) = EncodingStrings.GraphemeCluster(emoji);
            Assert.AreEqual(1, actualTextElements);
            Assert.AreEqual(2, actualCounter);

            emoji = "👩‍🚒"; // a woman fire fighter
            (actualCounter, actualTextElements) = EncodingStrings.GraphemeCluster(emoji);
            Assert.AreEqual(1, actualTextElements);
            Assert.AreEqual(5, actualCounter);
        }
    }
}
