using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AboutString.MagicString;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="DeclareStrings"/> class
    /// </summary>
    [TestClass]
    public class DeclareStringsTests
    {
        [TestMethod]
        public void DeclareStringWithStringTypeTest()
        {
            string str = DeclareStrings.DeclareStringWithStringType();
            Assert.AreEqual("DeclareStringWithStringType", str);
        }

        [TestMethod]
        public void DeclareStringWithStringKeyWordTest()
        {
            string str = DeclareStrings.DeclareStringWithStringKeyWord();
            Assert.AreEqual("DeclareStringWithStringKeyWord", str);
        }

        [TestMethod]
        public void DeclareStringWithVarTest()
        {
            string str = DeclareStrings.DeclareStringWithVar();
            Assert.AreEqual("DeclareStringWithVar", str);
        }

        [TestMethod]
        public void DeclareStringWithNullValueTest()
        {
            string str = DeclareStrings.DeclareStringWithNullValue();
            Assert.IsNull(str); ;
        }

        [TestMethod]
        public void DeclareEmptyStringWithQuotesTest()
        {
            string str = DeclareStrings.DeclareEmptyStringWithQuotes();
            Assert.AreEqual("", str);
        }

        [TestMethod]
        public void DeclareConstantStringTest()
        {
            string str = DeclareStrings.DeclareConstantString();
            Assert.AreEqual("DeclareConstantString", str);
        }

        [TestMethod]
        public void DeclareStringWithDoubleQuoteCharacterTest()
        {
            string str = DeclareStrings.DeclareStringWithDoubleQuoteCharacter();
            Assert.AreEqual("Oscar Wilde said \"Be yourself; everyone else is already taken\"", str);
        }

        [TestMethod]
        public void DeclareStringWithBackslashTest()
        {
            string str = DeclareStrings.DeclareStringWithBackslash();
            Assert.AreEqual("C:\\tmp\\Project", str);
        }

        [TestMethod]
        public void DeclareStringWithVerbatimLiteralWithBackslashTest()
        {
            string str = DeclareStrings.DeclareStringWithVerbatimLiteralWithBackslash();
            Assert.AreEqual(@"C:\tmp\Project", str);
        }

        [TestMethod]
        public void DeclareStringWithVerbatimLiteralWithDoubleQuotesTest()
        {
            string str = DeclareStrings.DeclareStringWithVerbatimLiteralWithDoubleQuotes();
            Assert.AreEqual(@"""Success is not final, failure is not fatal: It is the courage to continue that counts."" - Winston Churchill", str);
        }

        [TestMethod]
        public void DeclareStringWithVerbatimLiteralContainingCodeTest()
        {
            string expectedStr = @"namespace AboutString
                        {
                            public class DeclareStrings
                            {
                            }
                        }";
            string actualStr = DeclareStrings.DeclareStringWithVerbatimLiteralContainingCode();
            Assert.AreEqual(expectedStr, actualStr);
        }

        [TestMethod]
        public void DeclareStringWithNewLineEscapeCharacterTest()
        {
            string str = DeclareStrings.DeclareStringWithNewLineEscapeCharacter();
            Assert.AreEqual("Chase you dreams,\nThey know the way", str);
        }

        [TestMethod]
        public void DeclareStringWithCarriageReturnEscapeCharacterTest()
        {
            string str = DeclareStrings.DeclareStringWithCarriageReturnEscapeCharacter();
            Assert.AreEqual("Be kind to yourself \r For you are worth it", str);
        }

        [TestMethod]
        public void DeclareStringWithHorizontalTabEscapeCharacterTest()
        {
            string str = DeclareStrings.DeclareStringWithHorizontalTabEscapeCharacter();
            Assert.AreEqual("Eat\tPray\tLove", str);
        }
    }

    [TestClass]
    public class MagicStringTests
    {
        /// <summary>
        /// This test demonstrates a bug because of a used Magic string within a code logic
        /// A user calls Channel instead of Chanel by mistake (typo)
        /// Expected result is Chanel №5 but the user receives Unknown instead
        /// </summary>
        [TestMethod]
        public void GetTopPerfumeOfABrandDemonstrateBugTest()
        {
            string topPerfume = MagicString.GetTopPerfumeOfABrand("Channel");
            Assert.AreEqual("Unknown", topPerfume);
            Assert.AreNotEqual("Chanel №5", topPerfume);
        }

        /// <summary>
        /// This test demonstrates a method to call strings
        /// that is more robust and less prone to errors
        /// Enums is one of the way to avoid bugs caused by magic strings
        /// </summary>
        [TestMethod]
        public void GetTopPerfumeOfABrandBestPracticeTest()
        {
            // string topPerfume = MagicString.GetTopPerfumeOfABrand(Brand.Channel); // compiler shows error because there is no Channel value on the enum Brand
            string topPerfume = MagicString.GetTopPerfumeOfABrand(Brand.Chanel);
            Assert.AreEqual("Chanel №5", topPerfume);
        }

        /// <summary>
        /// This test demonstrates a bug because of a used Magic string within a code logic
        /// The returned message should be for a VIP user
        /// However, the returned message welcomes a regular user, not the VIP one which is incorrect behavior (bug)
        /// 
        /// This happens because the code uses 'VIP' type but not "Vip"
        /// As a user of the API I might not know that the API is case sensitive
        /// </summary>
        [TestMethod]
        public void GetWebsiteWelcomeMessageDemonstrateBugTest()
        {
            string welcomeMessage = MagicString.GetWebsiteWelcomeMessage("Vip");
            Assert.AreEqual("Welcome back, dear user!", welcomeMessage);
            Assert.AreNotEqual("Welcome, esteemed VIP member! We roll out the red carpet for you as a valued VIP user!", welcomeMessage);
        }

        /// <summary>
        /// This method demonstrates how to avoid magic strings by using contstants
        /// As an API user I should not worry about case sensitivity and can use the constant to call the desired API
        /// This way, the VIP user of a fashion website receives the correct welcome message
        /// </summary>
        [TestMethod]
        public void GetWebsiteWelcomeMessageUsingConstTest()
        {
            string welcomeMessage = MagicString.GetWebsiteWelcomeMessageUsingConst(UserTypes.VipUser);
            Assert.AreEqual("Welcome, esteemed VIP member! We roll out the red carpet for you as a valued VIP user!", welcomeMessage);
        }
    }

    [TestClass]
    public class InternPoolTests
    {
        [TestMethod]
        [DataRow("DeclareString", "DeclareString", true)]
        [DataRow("DeclareString", "DeclareString_", false)]
        [DataRow("cat", "dog", false)]
        [DataRow("123", "123", true)]
        [DataRow("123", "1234", false)]
        [DataRow("???", "???", true)]
        [DataRow("!!!", "!!!!!", false)]
        public void GetTopPerfumeOfABrandDemonstrateBugTest(string str1, string str2, bool isTheSameStringExpected)
        {
            bool isTheSameStringActual = InternPool.CompareStringsHashCodeOnInternalPool(str1, str2);
            Assert.AreEqual(isTheSameStringExpected, isTheSameStringActual);
        }
    }
}
