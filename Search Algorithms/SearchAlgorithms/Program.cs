using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ISearchEngine engine = GetSearchEngine();
            Measure(engine);
        }
        public static ISearchEngine GetSearchEngine()
        {
            Console.WriteLine("select mode: SIMPLE, SENTINEL, IMPROVED or BINARY");
            string mode = Console.ReadLine();
            switch (mode)
            {
                case "SIMPLE":
                    return new SimpleSearchEngine();
                case "IMPROVED":
                    return new ImprovedSearchEngine();
                case "BINARY":
                    return new BinarySearchEngine();
                case "SENTINEL":
                    return new ImprovedWithSentinelSearchEngine();
                default:
                    Console.WriteLine("No mode chosen, closing");
                    return null;
            }
        }

        static void Measure(ISearchEngine engine)
        {
            int[] Array1 = CreateArray(9999);
            // for best case.
            int bestCase = Array1[0];
            // for worst case.
            int worstCase = -1;
            long bestCaseTime;
            long worstCaseTime;
            var watch = new System.Diagnostics.Stopwatch();
            // start for best case.
            watch.Start();
            engine.Search(Array1, bestCase);
            watch.Stop();
            bestCaseTime = watch.ElapsedMilliseconds;
            // reset to calculate worst case.
            watch.Reset();
            watch.Start();
            engine.Search(Array1, worstCase);
            watch.Stop();
            worstCaseTime = watch.ElapsedMilliseconds;
            Console.WriteLine($"Best case: {bestCaseTime}ms,\nWorst case: {worstCaseTime}ms");
        }

        static int[] CreateArray(int size)
        {
            // To create a array.
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            return array;
        }
        static void Filling(int[] Array)
        {
            Random rd = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rd.Next(7, 101);
            }
        }
    }
}
