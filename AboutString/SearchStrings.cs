using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AboutString
{
    /// <summary>
    /// Explore functionality to search elements within a string
    /// </summary>
    public class SearchStrings
    {
        /// <summary>
        /// Specifies whether string data contains a specific element
        /// </summary>
        /// <returns>True if contains, false otherwise</returns>
        public static bool DoesStringContain(string data, string elementToSearch)
        {
            if (data == null || elementToSearch == null)
            {
                return false;
            }
            return data.Contains(elementToSearch);
        }

        /// <summary>
        /// Specifies whether string data contains a specific element taking culture into account
        /// </summary>
        /// <returns>True if contains, false otherwise</returns>
        public static bool DoesStringStartWith(string data, string elementToSearch, StringComparison comparison)
        {
            return data.StartsWith(elementToSearch, comparison);
        }

        /// <summary>
        /// Specifies whether string data contains specific characters
        /// </summary>
        /// <returns>True if contains, false otherwise</returns>
        public static bool DoesStringContainChar(string data, char characterToSearch)
        {
            return data.Contains(characterToSearch);
        }
        
        /// <summary>
        /// Gets the index of an element within string data
        /// </summary>
        /// <returns>Integer index of an element if found, -1 otherwise</returns>
        public static int GetIndexWithinString(string data, string elementToSearch, StringComparison stringComparison)
        {
            return data.IndexOf(elementToSearch, stringComparison);
        }

        /// <summary>
        /// Gets the index of an element within string data starting at a defined index within given count of subsequent characters
        /// </summary>
        /// <returns>Integer index of an element if found, -1 otherwise</returns>
        public static int GetIndexWithinStringInGivenRange(string data, string elementToSearch, int startAt, int countToExplore, StringComparison stringComparison)
        {
            return data.IndexOf(elementToSearch, startAt, countToExplore, stringComparison);
        }

        /// <summary>
        /// Gets the index of a character within string data
        /// </summary>
        /// <returns>Integer index of an element if found, -1 otherwise</returns>
        public static int GetIndexOfCharWithinString(string data, char [] charactersToSearch)
        {
            return data.IndexOfAny(charactersToSearch);
        }

        /// <summary>
        /// Validates if given string data matches the provide pattern
        /// </summary>
        public static bool DoesStringMatchAPattern(string data, string pattern)
        {
            Match match = Regex.Match(data, pattern);
            return match.Success;
        }

        /// <summary>
        /// Specifies whether string data contains certain characters sequence
        /// 
        /// Span<T> and ReadOnlySpan<T> introduced with C# 7.2 and .NET Core 2.1
        /// - Zero-allocating parsing
        /// - Optimized for high-performance scenarios
        /// It should not need to resort using spans for most situations, but it is really worth knowing that they exist
        /// 
        /// Span<T> (earlier known as Slice) is a value type with almost zero overhead. It provides a type-safe way to work with a contiguous block of memory such as: Arrays and subarrays.
        /// Slice - slicing unlike regular string operations does not allocate any new strings or memory
        /// Instead it narrows an existing view over the current memory
        /// Slicing produces a new read-only span representing the reduced view
        /// 
        /// SequenceEqual returns a true boolean value if the sequences are identical
        /// </summary>
        public static bool DoesStringContainCharsWithSpan(string data, char[] arrayOfCharacters)
        {
            ReadOnlySpan<char> arrayOfCharactersSpan = arrayOfCharacters;
            ReadOnlySpan<char> dataSpan = data.AsSpan();

            bool isValid = dataSpan.Slice(0, arrayOfCharactersSpan.Length).SequenceEqual(arrayOfCharactersSpan);
            return isValid;
        }
    }
}
