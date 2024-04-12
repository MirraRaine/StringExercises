using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace AboutString
{
    public class EqualityStrings
    {
        /// <summary>
        /// Strings literals are added to the intern pool.Repeated string literals are referencing the same string instance.
        /// if the same instance is referenced on pool the strings are considered equal
        /// </summary>
        public static bool CompareStringsWithEquals(string str1, string str2)
        {
            return str1.Equals(str2);
        }

        public static bool CompareStringsWithEqualsAndStringComparison(string str1, string str2, StringComparison strComparison)
        {
            return str1.Equals(str2, strComparison);
        }

        /// <summary>
        /// Equality is treated differently on different framework versions
        /// Also, by adding the below config to csproj will reproduce behavior like on netcoreapp because of
        /// used National Language Support (NLS) on Windows
        /// <ItemGroup>
        /// <RuntimeHostConfigurationOption Include = "Sstem.Globalization.UseNls Value = "true">
        ///  </ItemGroup>
        ///  It will show same results as netcoreapp3.1
        /// </summary>
        public static bool ComareStringsWithCultureExample()
        {
            CultureInfo initialCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo("de-DE");
            string germanFootball1 = "fussball";
            string germanFootbal2 = "fußball";
            string germanFootbal3 = "fu\u00DFball";

            bool equals = germanFootball1.Equals(germanFootbal2); //false on .net5.0 // false on netcoreapp3.1
            Assert.IsFalse(equals);

            equals = germanFootball1.Equals(germanFootbal2, StringComparison.CurrentCulture); //false on .net5.0 // true on netcoreapp3.1
            Assert.IsFalse(equals);

            equals = germanFootball1.Equals(germanFootbal3, StringComparison.CurrentCulture); //false on .net5.0 // true on netcoreapp3.1
            Assert.IsFalse(equals);

            CultureInfo.CurrentCulture = initialCulture;

            return true;
        }

        /// <summary>
        /// Equivalent to Equals with no StringComparison
        /// </summary>
        public static bool CompareStringsWithEqualityOperators(string str1, string str2)
        {
            return str1 == str2;
        }
    }
}
