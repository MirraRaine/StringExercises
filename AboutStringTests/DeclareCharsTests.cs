using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="DeclareChars"/> class
    /// </summary>
    [TestClass]
    public class DeclareCharsTests
    {
        [TestMethod]
        public void DeclareCharWithSystemCharTest()
        {
            char ch = DeclareChars.DeclareCharWithSystemChar();
            Assert.AreEqual('1', ch);
        }

        [TestMethod]
        public void DeclareCharWithAliasCharTypeTest()
        {
            char ch = DeclareChars.DeclareCharWithAliasCharType();
            Assert.AreEqual('1', ch);
        }

        [TestMethod]
        public void DeclareCharWithVarTest()
        {
            char ch = DeclareChars.DeclareCharWithVar();
            Assert.AreEqual('1', ch);
        }

        [TestMethod]
        public void DeclareConstantCharTest()
        {
            char ch = DeclareChars.DeclareConstantChar();
            Assert.AreEqual('1', ch);
        }

        [TestMethod]
        public void DeclareDefaultCharTest()
        {
            char ch = DeclareChars.DeclareDefaultChar();
            Assert.AreEqual('\0', ch);
        }

        [TestMethod]
        public void DeclareHCharTest()
        {
            char ch = DeclareChars.DeclareHChar();
            Assert.AreEqual('H', ch);
        }

        [TestMethod]
        public void DeclareHCharWithUnicodeEscapeSequenceTest()
        {
            char ch = DeclareChars.DeclareHCharWithUnicodeEscapeSequence();
            Assert.AreEqual('H', ch);
        }

        [TestMethod]
        public void DeclareHCharWithHexidecimalEscapeSequenceTest()
        {
            char ch = DeclareChars.DeclareHCharWithHexidecimalEscapeSequence();
            Assert.AreEqual('H', ch);
        }

        [TestMethod]
        public void DeclareHCharWithHexidecimalEscapeSequenceOmitZeroTest()
        {
            char ch = DeclareChars.DeclareHCharWithHexidecimalEscapeSequenceOmitZero();
            Assert.AreEqual('H', ch);
        }

        [TestMethod]
        public void DeclareHCharWithDecimalValueTest()
        {
            char ch = DeclareChars.DeclareHCharWithDecimalValue();
            Assert.AreEqual('H', ch);
        }

        [TestMethod]
        public void DeclareIntegerFromCharTest()
        {
            int ch = DeclareChars.DeclareIntegerFromChar();
            Assert.AreEqual((int)'H', ch);
        }

        [TestMethod]
        public void CasingCharsTest()
        {
            char actual = DeclareChars.CasingChars();
            char expected = char.ToLower('H');
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CharInfoTest()
        {
            char[] characters = new[] { 'a', '1', ' ', '.' };
            string actual = DeclareChars.CharInfo(characters);
            string expected = "'a' is letter; '1' is digit; ' ' is whitespace; ' ' is separator; '.' is punctuation; ";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RepeatCharsInStringTest()
        {
            string input = "Hello World";
            string actual = DeclareChars.RepeatCharsInString(input, '-');
            string expected = input + "\n" + "-----------";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertIntToCharThroughCastingTest()
        {
            char actual = DeclareChars.ConvertIntToCharThroughCasting(72);
            char expected = 'H';
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertCharToIntThroughCastingTest()
        {
            int actual = DeclareChars.ConvertCharToIntThroughCasting('H');
            int expected = 72;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertCharToIntThroughCasting2Test()
        {
            char actual = DeclareChars.ConvertCharToIntThroughCasting2(70, 2);
            char expected = 'H';
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertCharThroughConvertTest()
        {
            char actual = DeclareChars.ConvertCharThroughConvert(70);
            char expected = 'F';
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertCharToIntThroughConvertTest()
        {
            int actual = DeclareChars.ConvertCharToIntThroughConvert('F');
            int expected = 70;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DemonstrateConvertOverflowExceptionTest()
        {
            try
            {
                DeclareChars.DemonstrateConvertOverflowException();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is OverflowException);
                Assert.AreEqual("Custom: Can't convert 70000 to char", ex.Message);
            }
        }

        [TestMethod]
        public void ConvertCharThroughIConvertableTest()
        {
            char actual = DeclareChars.ConvertCharThroughIConvertable(50);
            char expected = '2';
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DemonstrateErrorWithIConvertableTest()
        {
            try
            {
                DeclareChars.DemonstrateErrorWithIConvertable('A');
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidCastException);
                Assert.AreEqual("Invalid cast from 'Char' to 'Boolean'.", ex.Message);
            }
        }

        [TestMethod]
        public void DemonstrateErrorWithIConvertable2Test()
        {
            try
            {
                DeclareChars.DemonstrateErrorWithIConvertable2();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is OverflowException);
                Assert.AreEqual("Custom: Can't convert 70000 to char", ex.Message);
            }
        }

        [TestMethod]
        public void StringFromCharArrayTest()
        {
            char[] charactersArray = new[] { 'c', 'h', 'a', 'r', 's' };
            string actual = DeclareChars.StringFromCharArray(charactersArray);
            string expected = "chars";
            Assert.AreEqual(expected, actual);
        }
    }
}
