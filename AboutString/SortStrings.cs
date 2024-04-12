using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AboutString
{
    public class SortStrings
    {
        public static string[] SortStringsApplyingStringComparer(string[] arrayToSort, StringComparer stringComparer)
        {
            IOrderedEnumerable<string> sorted = arrayToSort.OrderBy(s => s, stringComparer);
            return sorted.ToArray();
        }

        public static string[] SortStringsApplyingStringComparerWithCulture(string[] arrayToSort, StringComparer stringComparer, CultureInfo culture)
        {
            CultureInfo.CurrentCulture = culture;
            SortedSet<string> strings = new SortedSet<string>(arrayToSort, stringComparer);
            CultureInfo.CurrentCulture = new CultureInfo("en-GB"); // update to local culture in order to let all unit tests pass, otherwise they use incorrect culture update here and fail
            return strings.ToArray();
        }
    }
}
