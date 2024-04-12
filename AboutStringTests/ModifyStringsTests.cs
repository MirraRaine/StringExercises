using AboutString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AboutString.ModifyStrings;

namespace AboutStringTests
{
    /// <summary>
    /// Tests for <see cref="ModifyStrings"/> class
    /// </summary>
    [TestClass]
    public class ModifyStringsTests
    {
        [TestMethod]
        public void FormatGuidsTest()
        {
            char separator = '.';
            const string paragraph = "“Solaris Station. Zero and zero. Docking complete. Over and out,” " +
                "came the lifeless voice of the control mechanism. " +
                "With both hands (I could sense a vague pressure on my chest, " +
                "and my innards felt like an irksome burden) I took hold of the grips directly opposite my shoulders and disconnected the cables. " +
                "A green sign reading EARTH came on, and the side of the capsule opened. The pneumatic berth pushed me gently in the back, " +
                "so that in order not to stumble I had to take a step forward.";
            string actualSplittedParagraphs = ModifyStrings.SplitParagraph(paragraph, separator);
            string expectedSplittedParagraphs = "0: “Solaris Station." +
                "1:  Zero and zero.2:  Docking complete." +
                "3:  Over and out,” came the lifeless voice of the control mechanism." +
                "4:  With both hands (I could sense a vague pressure on my chest, and my innards felt like an irksome burden) I took hold of the grips directly opposite my shoulders and disconnected the cables." +
                "5:  A green sign reading EARTH came on, and the side of the capsule opened." +
                "6:  The pneumatic berth pushed me gently in the back, so that in order not to stumble I had to take a step forward." +
                "7: .";
            Assert.AreEqual(expectedSplittedParagraphs, actualSplittedParagraphs);
        }

        [TestMethod]
        public void SplitDataWithMultipleSeparatorsTest()
        {
            char[] separators = new char[] { ',', ':', ';', '|' };
            const string data = "jfvk:djfkjHBJHV|kdskjf;jsknkuH;KGBjcgSRE,SRjk:sdlfj|jfRDknk,reiYFTD;Rvsgj|fjs";
            string actualSplittedData = ModifyStrings.SplitDataWithMultipleSeparators(data, separators);
            string expectedSplittedData = "" +
                "0: jfvk" +
                "1: djfkjHBJHV" +
                "2: kdskjf" +
                "3: jsknkuH" +
                "4: KGBjcgSRE" +
                "5: SRjk" +
                "6: sdlfj" +
                "7: jfRDknk" +
                "8: reiYFTD" +
                "9: Rvsgj" +
                "10: fjs";
            Assert.AreEqual(expectedSplittedData, actualSplittedData);
        }


        [TestMethod]
        [DataRow("192.168.0.1", true)]
        [DataRow("127.0.0.1", true)]
        [DataRow("0800 123 4567", false)]
        [DataRow("0.0.0.0", true)]
        public void SplitIPsTests(string ip, bool expectedIsIp)
        {
            bool actualIsIp = ModifyStrings.SplitIPs(ip);
            Assert.AreEqual(expectedIsIp, actualIsIp);
        }

        [TestMethod]
        public void ParsePerfumeDataTests()
        {
            string[] perfumeData = new[] {
            "Brand: Versace",
            "Perfume Name: Bright Crystal.",
            "Volume (in ml): 50",
            "Launched in: 2006",
            "Nose: Alberto Morillas"
            };
            Perfume actualPerfume = ModifyStrings.ParsePerfumeData(perfumeData);
            Assert.AreEqual("Versace", actualPerfume.Brand);
            Assert.AreEqual("Bright Crystal", actualPerfume.Name);
            Assert.AreEqual(50, actualPerfume.Volume);
            Assert.AreEqual(2006, actualPerfume.LaunchYear);
            Assert.AreEqual("Alberto Morillas", actualPerfume.Nose);
        }

        [TestMethod]
        public void ChangeCaseTests()
        {
            const string name = "Mirra Raine";

            string actualInput = ModifyStrings.ChangeCaseToUpperInvariant(name);
            string expectedInput = "MIRRA RAINE";
            Assert.AreEqual(expectedInput, actualInput);

            actualInput = ModifyStrings.ChangeCaseToLowerInvariant(name);
            expectedInput = "mirra raine";
            Assert.AreEqual(expectedInput, actualInput);

            char character = 'a';
            char expectedChar = 'a';
            char actualChar = ModifyStrings.ChangeCharCaseToLowerInvariant(character);
            Assert.AreEqual(expectedChar, actualChar);

            character = 'A';
            expectedChar = 'a';
            actualChar = ModifyStrings.ChangeCharCaseToLowerInvariant(character);
            Assert.AreEqual(expectedChar, actualChar);
        }

        [TestMethod]
        public void ChangeJsonCaseTests()
        {
            string perfumeJsonRepresentation = "fragrance_chemicals_in_the_list_of_ingredients";
            string actualPerfumeTitleCamelCase = ModifyStrings.ChangeJsonCase(perfumeJsonRepresentation);
            string expectedPerfumeTitleCamelCase = "Fragrance Chemicals In The List Of Ingredients";
            Assert.AreEqual(expectedPerfumeTitleCamelCase, actualPerfumeTitleCamelCase);
        }

        [TestMethod]
        public void FormatWhitespaceTests()
        {
            string input = "    This is a string with whitespace     ";
            string actualOutput = ModifyStrings.FormatWhitespaceTrim(input);
            string expectedOutput = "This is a string with whitespaceEND";
            Assert.AreEqual(expectedOutput, actualOutput);

            actualOutput = ModifyStrings.FormatWhitespaceTrimStart(input);
            expectedOutput = "This is a string with whitespace     END";
            Assert.AreEqual(expectedOutput, actualOutput);

            actualOutput = ModifyStrings.FormatWhitespaceTrimEnd(input);
            expectedOutput = "    This is a string with whitespaceEND";
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void FormatCodeCommentTest()
        {
            string codeComment = "/// This is a code comment ";
            string actualOutput = ModifyStrings.FormatCodeComment(codeComment);
            string expectedOutput = "This is a code comment";
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void FormatPadLeftTest()
        {
            string[] data = new[] {
            "Dior",
            "Chanel",
            "Lancome",
            "Yves Saint Lorain",
            };
            string actualOutput = ModifyStrings.FormatPerfumeBrandsPadLeft(data);
            string expectedOutput =
                "           Dior" +
                "         Chanel" +
                "        Lancome" +
                "Yves Saint Lorain";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void StandardizeNamesListTest()
        {
            string[] namesList = new[] {
            "1.  Anne Flipo",
            "Quentin Bisch",
            "Pierre Guillaume",
            "11. Alberto Morillas",
            "10.Nathalie Lorson"
            };
            string actualOutput = ModifyStrings.StandardizeNamesList(namesList);
            string expectedOutput = " Anne Flipo;Quentin Bisch;Pierre Guillaume;Alberto Morillas;Nathalie Lorson;";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
