using System;
using System.Threading;

namespace AboutString
{
    /// <summary>
    /// Class to experiment with strings comparison
    /// The result of the comparison is given by:
    /// <list type="bullet">
    /// <item><description>'-' -> the first string precedes the second string</description></item>
    /// <item><description>'0' -> strings are equal</description></item>
    /// <item><description>'+' -> the first string follows the second stringl</description></item>
    /// </list>
    /// </summary>
    public class CompareStrings
    {
        /// <summary>
        /// Strings comparison with the current given culture
        /// </summary>
        /// <param name="str1">String value one</param>
        /// <param name="str2">String value two</param>
        /// <returns>Tuple containing (comparison, culture)</returns>
        public static (int, string) CompareWithCurrentCulture(string str1, string str2)
        {
            string culture = Thread.CurrentThread.CurrentCulture.DisplayName;
            int comparison = str1.CompareTo(str2);
            return (comparison, culture);
        }

        /// <summary>
        /// Strings comparison using CompareOrdinal
        /// </summary>
        /// <param name="str1">String value one</param>
        /// <param name="str2">String value two</param>
        /// <returns>Comparison int value result</returns>
        public static int CompareWithStringOrdinal(string str1, string str2)
        {
            int comparison = string.CompareOrdinal(str1, str2);
            return comparison;
        }

        /// <summary>
        /// Conpare strings using StringComparison option
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="stringComparison"></param>
        /// <returns>Comparison int value result</returns>
        public static int CompareWithStringComparison(string str1, string str2, StringComparison stringComparison)
        {
            int comparison = string.Compare(str1, str2, stringComparison);
            return comparison;
        }
    }
}
