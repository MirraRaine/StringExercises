using System;

namespace AboutString
{
    /// <summary>
    /// A string represents text as a sequence of UTF-16 code units meaning it represents information in a text format.
    /// String is an immutable sequence of characters. 
    /// String is derived from Objects making it a reference type. 
    /// String objects always live in the heap and never on thread's stack.
    /// 
    /// String literal is a sequence of characters enclosed in double quotation marks -> e.g., "my literal"
    /// 
    /// This class shows how to declare strings.
    /// </summary>
    public class DeclareStrings
    {
        /// <summary>
        /// You cannot delcare a String object from a literal string using 'new' operator
        /// because String constructor does not provide this option
        /// </summary>
        private static void FailToDeclareStringWithNewOperator()
        {
            // System.String str = new System.String("Declare string with new operator");
        }

        /// <summary>
        /// Use the simplified syntax to declare a new string with a string literal
        /// </summary>
        /// <returns>new string</returns>
        public static string DeclareStringWithStringType()
        {
            String str = "DeclareStringWithStringType";
            return str;
        }

        /// <summary>
        /// As string is very popular, .NET contains 'string' keyword as alias to System.String type
        /// This method represents how to declare System.String type using 'string' keyword
        /// Best Practice: This is the preferred method to declare strings
        /// </summary>
        /// <returns>new string</returns>
        public static string DeclareStringWithStringKeyWord()
        {
            string str = "DeclareStringWithStringKeyWord";
            return str;
        }

        /// <summary>
        /// Declare string with 'var' keyword
        /// This method of types declaration is based on engineer's preference and team's standards
        /// </summary>
        /// <returns>new string</returns>
        public static string DeclareStringWithVar()
        {
            var str = "DeclareStringWithVar";
            return str;
        }

        /// <summary>
        /// Declare string with null value
        /// As string is a reference type, the null value is acceptable
        /// </summary>
        /// <returns>null</returns>
        public static string DeclareStringWithNullValue()
        {
            string str = null;
            return str;
        }

        /// <summary>
        /// Declare empty string with quotes
        /// Less preferred way over DeclareEmptyStringWithStaticField
        /// </summary>
        /// <returns>Empty Value string</returns>
        public static string DeclareEmptyStringWithQuotes()
        {
            string str = "";
            return str;
        }

        /// <summary>
        /// Declare empty string with quotes
        /// Less preferred way
        /// Best Practice: the method is preferred over DeclareEmptyStringWithQuotes
        /// </summary>
        /// <returns>Empty Value string</returns>
        public static string DeclareEmptyStringWithStaticField()
        {
            string str = string.Empty;
            return str;
        }

        /// <summary>
        /// Declare constant string
        /// Best Practice: this method may protect from accidental string misuse.
        /// This method is preferred in case a string value should never be changed
        /// </summary>
        /// <returns>new constant string</returns>
        public static string DeclareConstantString()
        {
            const string str = "DeclareConstantString";

            // str = "Error"; // The Compiler shows an error because str is not a variable but constant and cannot be changed
            return str;
        }

        /// <summary>
        /// Declare string with double quates using backslash.
        /// Backslash inside a string literal is treated as the start of an escape sequence
        /// </summary>
        /// <returns>Oscar Wilde's phrase with double quotes</returns>
        public static string DeclareStringWithDoubleQuoteCharacter()
        {
            string str = "Oscar Wilde said \"Be yourself; everyone else is already taken\"";
            return str;
        }

        /// <summary>
        /// Declare string with backslash on the string literal
        /// Use double backslash to escape one backslash
        /// </summary>
        /// <returns>Path to folder</returns>
        public static string DeclareStringWithBackslash()
        {
            string str = "C:\\tmp\\Project";
            return str;
        }

        /// <summary>
        /// Declare string with verbatim literal containing backslash by using @ character
        /// </summary>
        /// <returns>Path to folder</returns>
        public static string DeclareStringWithVerbatimLiteralWithBackslash()
        {
            string str = @"C:\tmp\Project";
            return str;
        }

        /// <summary>
        /// Declare string with verbatim literal containing double quotes by using @ character
        /// </summary>
        /// <returns>Winston Churchill's phrase with double quote</returns>
        public static string DeclareStringWithVerbatimLiteralWithDoubleQuotes()
        {
            string str = @"""Success is not final, failure is not fatal: It is the courage to continue that counts."" - Winston Churchill";
            return str;
        }

        /// <summary>
        /// Declare string with verbatim literal containing C# code
        /// </summary>
        /// <returns>String with c# code block</returns>
        public static string DeclareStringWithVerbatimLiteralContainingCode()
        {
            string code = @"namespace AboutString
                        {
                            public class DeclareStrings
                            {
                            }
                        }";
            return code;
        }

        /// <summary>
        /// Declare string with a new line on the string literal
        /// \n is used to declare a new line
        /// </summary>
        /// <returns>string with a nice phrase</returns>
        public static string DeclareStringWithNewLineEscapeCharacter()
        {
            string str = "Chase you dreams,\nThey know the way";
            return str;
        }

        /// <summary>
        /// Declare string with a carriage return on the string literal
        /// \r is used for carriage return
        /// </summary>
        /// <returns>string with a nice phrase</returns>
        public static string DeclareStringWithCarriageReturnEscapeCharacter()
        {
            string str = "Be kind to yourself \r For you are worth it";
            return str;
        }

        /// <summary>
        /// Declare string with a horizontal tab on the string literal
        /// It is used for a horizontal tab
        /// </summary>
        /// <returns>string with a nice phrase</returns>
        public static string DeclareStringWithHorizontalTabEscapeCharacter()
        {
            string str = "Eat\tPray\tLove";
            return str;
        }
    }

    /// <summary>
    /// Magic string refers to a literal that is hardcoded in the code without any explanation or constant declaration.
    /// Using magic strings is generally considered as bad practice
    /// because it can lead to maintainability issues and 
    /// makes it difficult to change the string value consistently through the codebase
    /// 
    /// When we repeat magic strings through code we may introduce a typo which can lead to runtime bug
    /// </summary>
    public class MagicString
    {
        /// <summary>
        /// This code uses magic strings defined in brand as it is hardcoded within the method body
        /// In case a user calls a method with a typo in brand name, the user will receive an incorrect result
        /// </summary>
        /// <param name="brand">Brand name</param>
        /// <returns>Top perfume of a brand</returns>
        public static string GetTopPerfumeOfABrand(string brand)
        {
            if (brand == "Chanel")
            {
                return "Chanel №5";
            }
            else if (brand == "Guerlain")
            {
                return "Shalimar";

            }
            else if (brand == "Dior")
            {
                return "J'adore";
            }
            else return "Unknown";
        }

        /// <summary>
        /// Brand names that produce perfumes
        /// </summary>
        public enum Brand
        {
            Chanel,
            Guerlain,
            Dior
        }

        /// <summary>
        /// This method demonstrates best practice to avoid bugs caused by magic strings
        /// Brand is defined as an enum instead of a string
        /// this helps to avoid typos in brand name while a user calls the method
        /// </summary>
        /// <param name="brand"></param>
        /// <returns>Top perfume of a brand</returns>
        public static string GetTopPerfumeOfABrand(Brand brand)
        {
            switch (brand)
            {
                case Brand.Chanel:
                    return "Chanel №5";
                case Brand.Guerlain:
                    return "Shalimar";
                case Brand.Dior:
                    return "J'adore";
                default:
                    return "Unknown";
            }
        }

        /// <summary>
        /// This code uses magic strings defined in userType as it is hardcoded within the method body
        /// In case a user calls the method with a typo in userType, the user will receive a wrong welcome message
        /// </summary>
        /// <param name="userType">Type of a user who enters the fashion website</param>
        /// <returns>Welcome message</returns>
        public static string GetWebsiteWelcomeMessage(string userType)
        {
            if (userType == "New")
            {
                return "Welcome to our fashion-forward community!";
            }
            else if (userType == "VIP")
            {
                return "Welcome, esteemed VIP member! We roll out the red carpet for you as a valued VIP user!";
            }
            else
            {
                return "Welcome back, dear user!";
            }
        }

        /// <summary>
        /// Class with constants that define type of a user who enters the fashion website
        /// If there is a necessity to change value of UserTypes, it can be done in one place (in the enum)
        /// </summary>
        public static class UserTypes
        {
            public const string NewUser = "New";
            public const string VipUser = "VIP";
        }

        /// <summary>
        /// This method demonstrates an improved way of calling strings through constants to avoid bugs caused by magic strings
        /// Also, constants make the code more readable
        /// </summary>
        /// <param name="userType">Type of a user who enters the fashion website</param>
        /// <returns>Welcome message</returns>
        public static string GetWebsiteWelcomeMessageUsingConst(string userType)
        {
            if (userType == UserTypes.NewUser)
            {
                return "Welcome to our fashion-forward community!";
            }
            else if (userType == UserTypes.VipUser)
            {
                return "Welcome, esteemed VIP member! We roll out the red carpet for you as a valued VIP user!";
            }
            else
            {
                return "Welcome back, dear user!";
            }
        }
    }

    /// <summary>
    /// The .NET CLR maintains a table called the intern pool, 
    /// that contains a reference to each unique string literal
    /// </summary>
    public class InternPool
    {
        /// <summary>
        /// Method receives 2 strings with the same or different literal value
        /// The compiler can recognise the same literal and stores a single reference into the Intern pool
        /// The method compares strings hashcode to recognise whether strings are stored as a single reference or not
        /// </summary>
        /// <param name="str1">String literal value 1</param>
        /// <param name="str2">String literal value 2</param>
        /// <returns>True if string literals are the same and stored as a single reference; False otherwise</returns>
        public static bool CompareStringsHashCodeOnInternalPool(string str1, string str2)
        {
            return str1.GetHashCode() == str2.GetHashCode();
        }
    }
}
