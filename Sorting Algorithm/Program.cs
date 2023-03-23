using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1= Bubble Sort, 2 = Merge Sort, 3 = Radix Sort");
            int sorting = int.Parse(Console.ReadLine());
            switch (sorting)
            {
                case 1:
                    BubbleSort();
                    break;
                case 2:
                    mergeSort();
                    break;
                case 3:
                    radixSort();
                    break;
                default:
                    break;
            }
        }
        // For the bubble Sort.
        public static void BubbleSort()
        {
            Bubble_Sort sort = new Bubble_Sort();
            int[] generator = CreateAscendingArray(1000);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            sort.bubbleSort(generator);
            watch.Stop();
            Console.WriteLine($"Ascending Order: Size={generator.Length}, Time={watch.ElapsedMilliseconds}ms");

            int[] generator2 = CreateDescendingArray(1000);
            var watch2 = new System.Diagnostics.Stopwatch();
            watch2.Start();
            sort.bubbleSort(generator2);
            watch2.Stop();
            Console.WriteLine($"Descending Order: Size={generator2.Length}, Time={watch2.ElapsedMilliseconds}ms");

            int[] generator3 = CreateRandomArray(1000);
            var watch3 = new System.Diagnostics.Stopwatch();
            watch3.Start();
            sort.bubbleSort(generator3);
            watch3.Stop();
            Console.WriteLine($"Random Array: Size={generator3.Length}, Time={watch3.ElapsedMilliseconds}ms");

            int[] generator4 = CreateVshapeArray(1000);
            var watch4 = new System.Diagnostics.Stopwatch();
            watch4.Start();
            sort.bubbleSort(generator4);
            watch4.Stop();
            Console.WriteLine($"V shape Array: Size={generator4.Length}, Time={watch4.ElapsedMilliseconds}ms");

            int[] generator5 = CreateAshapeArray(1000);
            var watch5 = new System.Diagnostics.Stopwatch();
            watch5.Start();
            sort.bubbleSort(generator5);
            watch5.Stop();
            Console.WriteLine($"A shape Array: Size={generator5.Length}, Time={watch5.ElapsedMilliseconds}ms");
            Main(null);
        }
        // For the merge sort.
        public static void mergeSort()
        {
            Merge_Sort merge = new Merge_Sort();
            int[] generator = CreateAscendingArray(1000000);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            merge.sort(generator, 0, generator.Length - 1);
            watch.Stop();
            Console.WriteLine($"Ascending Order: Size={generator.Length}, Time={watch.ElapsedMilliseconds}ms");

            int[] generator2 = CreateDescendingArray(1000000);
            var watch2 = new System.Diagnostics.Stopwatch();
            watch2.Start();
            merge.sort(generator2, 0, generator2.Length - 1);
            watch2.Stop();
            Console.WriteLine($"Descending Order: Size={generator2.Length}, Time={watch2.ElapsedMilliseconds}ms");

            int[] generator3 = CreateRandomArray(1000000);
            var watch3 = new System.Diagnostics.Stopwatch();
            watch3.Start();
            merge.sort(generator3, 0, generator3.Length - 1);
            watch3.Stop();
            Console.WriteLine($"Random Array: Size={generator3.Length}, Time={watch3.ElapsedMilliseconds}ms");

            int[] generator4 = CreateVshapeArray(1000000);
            var watch4 = new System.Diagnostics.Stopwatch();
            watch4.Start();
            merge.sort(generator4, 0, generator4.Length - 1);
            watch4.Stop();
            Console.WriteLine($"V shape Array: Size={generator4.Length}, Time={watch4.ElapsedMilliseconds}ms");

            int[] generator5 = CreateAshapeArray(1000000);
            var watch5 = new System.Diagnostics.Stopwatch();
            watch5.Start();
            merge.sort(generator5, 0, generator5.Length - 1);
            watch5.Stop();
            Console.WriteLine($"A shape Array: Size={generator5.Length}, Time={watch5.ElapsedMilliseconds}ms");
            Main(null);
        }
        // For the radix sort.
        public static void radixSort()
        {
            RadixSort radix = new RadixSort();
            int[] generator = CreateAscendingArray(100000);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            radix.radixsort(generator, generator.Length);
            watch.Stop();
            Console.WriteLine($"Ascending Order: Size={generator.Length}, Time={watch.ElapsedMilliseconds}ms");

            int[] generator2 = CreateDescendingArray(10000);
            var watch2 = new System.Diagnostics.Stopwatch();
            watch2.Start();
            radix.radixsort(generator2, generator2.Length);
            watch2.Stop();
            Console.WriteLine($"Descending Order: Size={generator2.Length}, Time={watch2.ElapsedMilliseconds}ms");

            int[] generator3 = CreateRandomArray(100000);
            var watch3 = new System.Diagnostics.Stopwatch();
            watch3.Start();
            radix.radixsort(generator3, generator3.Length);
            watch3.Stop();
            Console.WriteLine($"Random Array: Size={generator3.Length}, Time={watch3.ElapsedMilliseconds}ms");

            int[] generator4 = CreateVshapeArray(100000);
            var watch4 = new System.Diagnostics.Stopwatch();
            watch4.Start();
            radix.radixsort(generator4, generator4.Length);
            watch4.Stop();
            Console.WriteLine($"V shape Array: Size={generator4.Length}, Time={watch4.ElapsedMilliseconds}ms");

            int[] generator5 = CreateAshapeArray(10000);
            var watch5 = new System.Diagnostics.Stopwatch();
            watch5.Start();
            radix.radixsort(generator5, generator5.Length);
            watch5.Stop();
            Console.WriteLine($"A shape Array: Size={generator5.Length}, Time={watch5.ElapsedMilliseconds}ms");
            Main(null);
        }
        static int[] CreateAscendingArray(int size)
        {
            // Ascending array implemetation.
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            return array;
        }
        static int[] CreateDescendingArray(int size)
        {
            // Descending array implemetation.
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Array.Reverse(array);
            return array;
        }
        static int[] CreateRandomArray(int size)
        {
            Random numbers = new Random();
            // Random Array array implemetation.
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = numbers.Next(0, 10000000);
                array[i] = randomNumber;

            }
            return array;
        }
        static int[] CreateVshapeArray(int size)
        {
            int count = 0;
            // V shape array implemetation.
            int[] array = new int[size];
            for (int i = array.Length / 2; i >= 0; i--)
            {
                array[count] = i;
                count++;
            }
            for (int i = array.Length - 1; i > array.Length / 2; i--)
            {
                array[i] = i;
            }

            return array;
        }
        static int[] CreateAshapeArray(int size)
        {

            // A shape array implemetation.
            int[] array = new int[size];
            int count = array.Length / 2;
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = i;
            }
            for (int i = array.Length / 2; i > 0; i--)
            {
                array[count] = i;
                count++;
            }

            return array;
        }

    }
}