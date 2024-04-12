using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AboutString
{
    /// <summary>
    /// Class to experiment with strings formatting and concatenation
    /// </summary>
    public class ConcatenateAndFormatStrings
    {
        public static string ConcatenateWithOperatorsOpt1()
        {
            string literalWelcome = "Hello" +
                " " +
                "Mirra" +
                " " +
                "Raine";
            return literalWelcome;
        }

        public static string ConcatenateWithOperatorsOpt2(string welcomeMessage, string firstName, string lastName)
        {
            welcomeMessage += " " + firstName + " " + lastName; // allocate new string
            return welcomeMessage;
        }

        public static string ConcatenateWithOperatorsOpt3(string welcomeMessage, string firstName, string lastName)
        {
            string finalWelcome = welcomeMessage + firstName + " " + lastName; // allocate new string
            return finalWelcome;
        }

        public static string CompositeFomatting(string firstName, string lastName)
        {
            string finalWelcome = string.Format("Hello {0} {1}", firstName, lastName);
            return finalWelcome;
        }

        public static string PriceCompositeFomattingWithCulture(CultureInfo culture, string priceText)
        {
            string formattedPrice = null;
            if (decimal.TryParse(priceText, out decimal price))
            {
                formattedPrice = string.Format(culture, "The price is {0:C}", price);
            }

            return formattedPrice;
        }

        public static string TemperatureCompositeFomattingWithCulture(CultureInfo culture, DateTime date, double temperature)
        {
            string formattedTemperature = string.Format(culture, "At {0:d}, the temp is {1:F2}C", date, temperature);
            return formattedTemperature;
        }

        /// <summary>
        /// Call alignment component by using alignment formatting
        /// -20 -> means 20 characters wide, left aligned
        /// time is right alighned
        /// </summary>
        public static string TimeSpanCompositeFomatting(string name, TimeSpan time)
        {
            string message = string.Format("Driver is {0,-20}. Lap Time is {1,10:mm\\ss\\.fff}", name, time);
            return message;
        }

        /// <summary>
        /// Concat string words with '+' operator
        /// </summary>
        /// <param name="words"></param>
        public static string ConcatStringsWithPlusOperator(string[] words)
        {
            string finalSentence = string.Empty;

            foreach (string word in words)
            {
                finalSentence = finalSentence + word; // we don't modify the string, we create a new string, remember about immutability
            }

            return finalSentence;
        }

        /// <summary>
        /// Concat words with string.Concat
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string ConcatStringsWithConcatFunc(string[] words)
        {
            string finalSentence = string.Concat(words);
            return finalSentence;
        }

        /// <summary>
        /// Concat strings with string.Join
        /// </summary>
        public static string ConcatStringsWithJoinFunc(string[] words)
        {
            string finalSentence = string.Join(" ", words);
            return finalSentence;
        }

        public static string StringInsertGreeting(string greeting)
        {
            string original = "Your greeting is: !";
            string finalMessage = original.Insert(original.IndexOf('!'), greeting);
            return finalMessage;
        }

        /// <summary>
        /// This method uses string iterpolation for formatting
        /// String interpolation is preferred against composite strings formatting
        /// string.concat and string.join are optimized and sufficient when just few changes need to be made to a string
        /// </summary>
        public static string StringInterpolation(CultureInfo culture, double temperature, DateTime dateTime)
        {
            FormattableString formattableString = $"At {dateTime:d} the temperature is {temperature:F2}C";
            string finalSentence = formattableString.ToString(culture);
            return finalSentence;
        }


        public static string StringBuilderPoem(IEnumerable<string> poem, DateTime dateTime, string author)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string sentence in poem)
            {
                sb.Append(sentence);
            }

            sb.Append($"Author {author}.").Append($"Written in {dateTime}");
            return sb.ToString();
        }

        public static (int, int, string) StringBuilderOptimizedCreation(string str, int iterateCount)
        {
            // showing capacity helps to optimize the string builder creation, 
            // as we know from the beginning what capacity we need, 
            // we are iterating from 0 to iterateCount -> iterateCount + 1
            StringBuilder sb = new StringBuilder(str, str.Length * (iterateCount + 1));

            for (int i = 0; i < iterateCount; i++)
            {
                sb.Append(str);
            }

            return (sb.Length, sb.Capacity, sb.ToString());
        }

        public static (int, int) StringBuilderOptimizedCreationWithEnsuredCapacity(string str, int iterateCount)
        {
            StringBuilder sb = new StringBuilder(str);

            //// by setting the capacity you ensure that no new instance of StringBuilder is
            ///created on the background to store more and more chracters
            //// instead, it will create 1 instance with expected capacity
            sb.EnsureCapacity(str.Length * (1 + iterateCount));

            for (int i = 0; i < iterateCount; i++)
            {
                sb.Append(str);
            }

            return (sb.Length, sb.Capacity);
        }

        public static string StringBuilderInsufficientCapacity(string str)
        {
            // this capacity will be insufficient for the needs of 10000 iterations
            StringBuilder sb = new StringBuilder(256, 2048);

            for (int i = 0; i < 10000; i++)
            {
                sb.Append(str); // -> fails with ArgumentOutOfRangeException
            }

            return sb.ToString();
        }

        public static string StringBuilderReplace(string str, string start, char charFrom, char charTo)
        {
            StringBuilder sb = new StringBuilder(str);

            start += " ";
            sb.Replace(charFrom, charTo);
            sb.Insert(0, start);

            return sb.ToString();
        }

        // PERFORMANCE CONSIDERATIONS

        private static readonly ObjectPool<StringBuilder> Pool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

        // Pooling introduces overhed by causing objects to live for the life of the application
        // - Limit the size of the pool to control this
        // prove that poolng provides expected improvements by benchmarking and profiling your code under realistic workloads
        public static string PoolingStringBuilders(string str)
        {
            // instance from pool, if it does not exist then new instance is created
            StringBuilder sbPooled = Pool.Get();
            try
            {
                sbPooled.Append(str);
                return sbPooled.ToString();
            }
            finally
            {
                Pool.Return(sbPooled);
            }
        }
    }
}
