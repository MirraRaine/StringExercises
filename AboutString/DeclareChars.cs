using System;
using System.Text;

namespace AboutString
{
    /// <summary>
    /// Char is build-in value type (struct) in .NET
    /// that represents a UTF-16 encoded character
    /// UTF-16 is a unicode Transformation Format
    /// Encoding the means by which characters are mapped to bytes of binary data stored in memory, on disk or transimitted over a network
    /// 
    /// .NET uses char structure to represent Unicode code points by using the UTF16 encoding
    /// char uses 2 bytes=16bits to store a numeric value.
    /// One or more chars may be needed to map to a final Unicode value, but for common Lating characters a single char is enough to represent each letter.
    /// 
    /// A string contains a buffer of sequence of chars each of which represents a UTF-16 code unit.
    /// </summary>
    public class DeclareChars
    {
        public static char DeclareCharWithSystemChar()
        {
            System.Char character = '1';
            return character;
        }

        public static char DeclareCharWithAliasCharType()
        {
            char character = '1';
            return character;
        }

        public static char DeclareCharWithVar()
        {
            char character = '1';
            return character;
        }

        /// <summary>
        /// New value cannot be assigned to a constant
        /// </summary>
        /// <returns></returns>
        public static char DeclareConstantChar()
        {
            const char character = '1';
            return character;
        }

        /// <summary>
        /// char is struct and it has a default value
        /// </summary>
        /// <returns></returns>
        public static char DeclareDefaultChar()
        {
            const char character = default; // -> '\0'
            return character;
        }

        public static char DeclareHChar()
        {
            const char letterH = 'H';
            return letterH;
        }

        public static char DeclareHCharWithUnicodeEscapeSequence()
        {
            const char letterH = '\u0048'; // unicode escape sequnce that represents H
            return letterH;
        }

        public static char DeclareHCharWithHexidecimalEscapeSequence()
        {
            const char letterH = '\x0048'; // hexidecimal representation of H
            return letterH;
        }

        public static char DeclareHCharWithHexidecimalEscapeSequenceOmitZero()
        {
            const char letterH = '\x48';
            return letterH;
        }

        public static char DeclareHCharWithDecimalValue()
        {
            const char letterH = (char)72; // cast the decimal representation of the unicode value to a char
            return letterH;
        }

        public static int DeclareIntegerFromChar()
        {
            const char letterH = (char)72; // cast the decimal representation of the unicode value to a char
            int letterHDecimal = letterH; // back to int
            return letterHDecimal;
        }

        public static char CasingChars()
        {
            const char letterH = 'H';
            return char.ToLower(letterH);
        }

        public static string CharInfo(char[] characters)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char character in characters)
            {
                if (char.IsLetter(character))
                {
                    builder.Append("'" + character + "'" + " is letter; ");
                }

                if (char.IsDigit(character))
                {
                    builder.Append("'" + character + "'" + " is digit; ");
                }

                if (char.IsWhiteSpace(character))
                {
                    builder.Append("'" + character + "'" + " is whitespace; ");
                }

                if (char.IsPunctuation(character))
                {
                    builder.Append("'" + character + "'" + " is punctuation; ");
                }

                if (char.IsSeparator(character))
                {
                    builder.Append("'" + character + "'" + " is separator; ");
                }
            }

            return builder.ToString();
        }

        public static string RepeatCharsInString(string input, char characterToRepeat)
        {
            string repeatedChars = new string(characterToRepeat, input.Length);
            return input + "\n" + repeatedChars;
        }

        /// <summary>
        /// Jeffrey Richter: Casting is the easiest way to convert a Char to a numeric value such as an Int32
        /// this is the most efficient technique because the compiler emits IL instructions to perform the conversion
        /// and no methods have to be called
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Char ConvertIntToCharThroughCasting(int value)
        {
            Char character = ((Char)value);
            return character;
        }

        public static int ConvertCharToIntThroughCasting(char character)
        {
            int value = ((Int32)character);
            return value;
        }

        public static Char ConvertCharToIntThroughCasting2(int a, int b)
        {
            Char character = unchecked((Char)(a + b));
            return character;
        }

        /// <summary>
        /// Jeffrey Richter: Convert through System.Convert type offers several static methods that are capable of converting char to a numeric type and vice versa
        /// </summary>
        /// <param name="value"></param>
        public static Char ConvertCharThroughConvert(int value)
        {
            Char character = Convert.ToChar(value);
            return character;
        }

        public static int ConvertCharToIntThroughConvert(Char character)
        {
            int value = Convert.ToInt32(character);
            return value;
        }

        /// <summary>
        /// Demonstrate OverflowException that is thrown if the conversion results in the loss of data
        /// </summary>
        public static void DemonstrateConvertOverflowException()
        {
            int number = 70000;
            try
            {
                Char character = Convert.ToChar(number); // too big for 16 bits
            }
            catch (OverflowException ex)
            {
                throw new OverflowException($"Custom: Can't convert {number} to char", ex);
            }
        }


        /// <summary>
        /// Jeffrey Richter: Convert through IConvertable interface -> 
        /// the Char type and all numeric types implement IConvertable interface
        /// It defines ToUInt16 and toChar
        /// It is the least efficient tecnique because calling n interface method on a value type requires
        /// that the instance be boxed - Char and all of the numeric types are value types.
        /// IConvertable throw a System.InvalidCastexception if the type cannot be converted
        /// 
        /// You need to explicitely cast the instance to IConvertable before you can call any of its methods
        /// 
        /// IFormatProvider is passed as null - it is useful if for some reason the conversion neeeds to take culture information into account
        /// </summary>
        public static Char ConvertCharThroughIConvertable(int value)
        {
            Char character = ((IConvertible)value).ToChar(null);
            return character;
        }

        public static int ConvertIntToCharThroughIConvertable(char character)
        {
            int value = ((IConvertible)character).ToInt32(null);
            return value;
        }

        /// <summary>
        /// Should throw System.InvalidCastException
        /// </summary>
        public static bool DemonstrateErrorWithIConvertable(char character)
        {
            bool value = ((IConvertible)character).ToBoolean(null);
            return value;
        }

        /// <summary>
        /// Should throw System.InvalidCastException
        /// </summary>
        public static void DemonstrateErrorWithIConvertable2()
        {
            int number = 70000;
            try
            {
                Char character = ((IConvertible)number).ToChar(null); // too big for 16 bits
            }
            catch (OverflowException ex)
            {
                throw new OverflowException($"Custom: Can't convert {number} to char", ex);
            }
        }

        /// <summary>
        /// Build string out of chracters arrays using string constructor directly
        /// </summary>
        public static string StringFromCharArray(char[] charactersArray)
        {
            string characterString = new string(charactersArray);
            return characterString;
        }
    }
}


