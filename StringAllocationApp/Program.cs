using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Buffers;
using System.Text;

namespace StringAllocationApp
{
    /// <summary>
    /// BenchmarkRunner is available on github
    /// Interesting discussion: https://stackoverflow.com/questions/52223682/how-to-interpret-the-results-from-benchmarkdotnet-and-dotmemory
    /// </summary>

    /// <summary>
    /// Reducing heap allocations
    /// - Using a char array from a pool to manyally manipulate characters before creating a string
    /// - Avoid heap allocations entirely by using a char array buffed allocated on the stack
    /// - Use the Create() method on the string type
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args) => BenchmarkRunner.Run<StringBenchmarks>();
    }

    /// <summary>
    /// There are 3 methods that give the same logic however it is represented with
    /// - regular string concatenation
    /// - string builder
    /// - string pool
    /// 
    /// Tip!
    /// Close all other applications before running benchmarks to achieve the most accurate results as they may affect your measurements
    /// 
    /// To run it, this should be added to a separated console app
    /// dotnet run -c release
    /// 
    /// It should be run in the release mode to ensure the benchmarks achieve the actual representation of production preformance
    /// 
    /// we will find the results on the console ordered from the slowest to the fastest which will be:
    /// - NoBuilder
    /// - Builder
    /// - PooledBuilder
    /// - StackAllocated
    /// - ArrayPool
    /// - StringCreate
    /// 
    /// </summary>
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.SlowestToFastest)]
    public class StringBenchmarks
    {
        private const string Sentence = "A short sentence."; // 17 chars

        private string _final;

        [Benchmark] // will be built and executed within its own console app to achieve process level of isoltion
        public void NoBuilder()
        {
            for (int a = 0; a < 100; a++)
            {
                string finalString = string.Empty;
                for (int i = 0; i < 50; i++)
                {
                    finalString += Sentence;
                }

                _final = finalString;
            }
        }

        [Benchmark]
        public void Builder()
        {
            for (int a = 0; a < 100; a++)
            {
                StringBuilder sb = new StringBuilder(1024);
                for (int i = 0; i < 50; i++)
                {
                    sb.Append(Sentence);
                }

                _final = sb.ToString();
            }
        }

        [Benchmark]
        public void PooledBuilder()
        {
            DefaultObjectPoolProvider provider = new DefaultObjectPoolProvider();
            ObjectPool<StringBuilder> pool = provider.CreateStringBuilderPool();

            for (int a = 0; a < 100; a++)
            {
                StringBuilder sbPooled = pool.Get();

                try
                {
                    for (int i = 0; i < 50; i++)
                    {
                        sbPooled.Append(Sentence);
                    }

                    _final = sbPooled.ToString();
                }
                finally
                {
                    pool.Return(sbPooled);
                }
            }
        }

        /// <summary>
        /// helps to avoid heap allocation
        /// </summary>
        [Benchmark]
        public void StackAllocated()
        {
            for (int a = 0; a < 100; a++)
            {
                ReadOnlySpan<char> sentenceSpan = Sentence.AsSpan();
                int length = sentenceSpan.Length;

                // Beware stackalloc, especially inside a loop - This is demo-ware!!

                Span<char> buffer = stackalloc char[1_024]; // 2KB // allocates memory directly on the stack, risky operation

                int position = 0;

                for (int i = 0; i < 50; i++)
                {
                    sentenceSpan.CopyTo(buffer.Slice(position));
                    position += length;
                }

                //_final = new string(buffer.Slice(0, position).ToArray()); // not sure but new string(buffer.Slice(0, position)) compile exception
                _final = new string(buffer.Slice(0, position));
            }
        }

        /// <summary>
        /// Arraypool avoids repeated allocations by allowing arrays to be reused across the life of the application. 
        /// This amortizes the cost of such allocations where arrays are needed often.
        /// </summary>
        [Benchmark]
        public void ArrayPool()
        {
            for (int a = 0; a < 100; a++)
            {
                ReadOnlySpan<char> sentenceSpan = Sentence.AsSpan();
                int length = sentenceSpan.Length;
                char[] buffer = ArrayPool<char>.Shared.Rent(1_024); // slightly larger than we need

                try
                {
                    Span<char> span = buffer.AsSpan();
                    int position = 0;

                    for (int i = 0; i < 50; i++)
                    {
                        sentenceSpan.CopyTo(span.Slice(position));
                        position += length;
                    }

                    _final = new string(span.Slice(0, position).ToArray()); // not sure but new string(span.Slice(0, position)) compile exception
                }
                finally
                {
                    ArrayPool<char>.Shared.Return(buffer);
                }
            }
        }


        //This method does not work for me from some reason, may be I need to run it on another .net version to get string.Create method etc.
        /// <summary>
        /// string.Create is introduced in .Net Cre 2.1
        /// Specialized and optimized way to create a string with a known length
        /// Fast allocates heap memry for the string
        /// Memory can be mutated before the string reference is returned
        /// </summary>
        [Benchmark]
        public void StringCreate()
        {
            for (int a = 0; a < 100; a++)
            {

                Int32 finalLength = Sentence.Length * 50;
                Int32 sentenceLength = Sentence.Length;
                _final = string.Create(finalLength, (Sentence, sentenceLength), concatAction);
            }
        }

        /// <summary>
        /// Callback in a form of a SpanAction
        /// Allows us to provide a delegate for mutating the strings underlying memory represented as a span of chars
        /// </summary>
        private static readonly SpanAction<char, ValueTuple<string, int>> concatAction = (chars, state) =>
        {
            (string sentence, int length) = state; // access to the state
            int position = 0;
            ReadOnlySpan<char> sentenceSpan = sentence.AsSpan();

            for (int i = 0; i < 50; i++)
            {
                sentenceSpan.CopyTo(chars.Slice(position));
                position += length;
            }
        };
    }
}
