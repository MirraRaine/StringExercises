using System.Globalization;
using System.Text;

namespace AboutString
{
    /// <summary>
    /// Encoding
    /// The means by which characters are mapped to bytes of binary data stored in memory, on disk or transmitted over the network
    /// ASCII
    /// - American standard code for information interchange. Deveoped in 1960.
    /// - Uses 7-bits to encode up to 128 characters
    /// includes non-printing, control characters
    /// - limited to only english charcters
    /// - used for http/s request line and headers
    /// 
    /// Unicode
    /// - origins dating back to 1987
    /// - uses a 16-bit charcter model
    /// - original proposal had some limitations
    /// --> version 2.0 removed the 16-bit limit with surrogate pairs
    /// - Continues to evolve with additional characters
    /// - Mainteined by the unicode consortium
    /// - contained 143,859 characters as of v13
    /// 
    /// Unicode code points
    /// - integer value ranging from 0 to 1,114,111
    ///  assigned to letters, symbols and control characters
    ///  - many code points are reserved for future use
    /// 
    /// Code point ranges
    /// - Basic Multilingual Plane (U+0000 - U+FFFF) -> 16-bit, 65,536 code points
    /// - Supplementary Planes (U+FFFF - U+10FFFF)   -> 21-bits, 1,048,575 code points (e.g. emoji characters) - 2 chars must be used in sequence to represent supplementary plane
    /// Surrogate pairs use two 16-bit values to represent a single 21-bit code point
    /// 
    /// Emoji smile
    /// HS - high surrogate
    /// LS - low surrogate
    /// Code point = 0x10000 + ((HS code point - xD800) * 0x0400) + (LS code point - 0xDC00) =
    ///            = 65,536 + ((HS code point - 55,296) * 1,024) + (LS code point - 56,320) = 
    ///            = 65,536 + ((55,357 - 55,296) * 1,024) + (56,862 - 56,320) = 128,512 = U+1F600
    ///            
    /// Encoding classes
    /// ASCII - encodes a limited range (128) of characters using 7-bits
    /// UTF-7 - represents characters as sequences of 7-bit ascii characters
    /// UTF-8 - represents each Unicode code point as a sequence of one to four bytes
    /// UTF-16 - represents each Unicode code point as a sequence of one or two 16-bit integers
    /// UTF-32 - represents each Unicode code point as a 32-bit integers
    /// </summary>
    public class EncodingStrings
    {
        public static int GetStringLength(string str)
        {
            return str.Length;
        }
        public static int GetLengthInTextElements(string str)
        {
            StringInfo stringInfo = new StringInfo(str);
            return stringInfo.LengthInTextElements;
        }

        public static (int, string) AsciiEncoding(string input)
        {
            // string input = "Some text to encode"; // first unput to try
            // string input = "Some text that includes an emoji 🤔 that is represented by U+1F914."; // after decoding ascii will not be able to represent emoji because it does not know how to deal with them, will be replaced with question marks
            int byteLength = Encoding.ASCII.GetByteCount(input);
            byte[] data = Encoding.ASCII.GetBytes(input);
            string decodedString = Encoding.ASCII.GetString(data);
            return (byteLength, decodedString);
        }

        public static (int, string) Utf8Encoding(string input)
        {
            int byteLength = Encoding.UTF8.GetByteCount(input);
            byte[] data = Encoding.UTF8.GetBytes(input);
            string decodedString = Encoding.UTF8.GetString(data);
            return (byteLength, decodedString);
        }

        /// <summary>
        /// Introduced in .NET core 3.0, the Rune type represents a Unicode scalar value
        /// </summary>
        public static void Runes()
        {
            // Rune letterA = new Rune('A'); // does not exist in the current framework version I use

        }

        /// <summary>
        /// Something which appears as one character may be formed from a combination of Unicode code points.
        /// The term for this is a grapheme cluster.
        /// E.g. á can be represented as one character, but can be represented as grapheme cluster (1 character as a and second character is carka)
        /// Pair of chars form the grapheme cluster
        /// .NET refers to Grapheme Cluser as Text Element
        /// System.Globalization.StringInfo provides functionality to splt a string into text elements and to iterate through those text elements.
        /// </summary>
        public static (int, int) GraphemeCluster(string input)
        {
            int counter = 0;
            foreach (char character in input)
            {
                counter++;
            }
            StringInfo stringInfo = new StringInfo(input);

            return (counter, stringInfo.LengthInTextElements);
        }
    }
}
