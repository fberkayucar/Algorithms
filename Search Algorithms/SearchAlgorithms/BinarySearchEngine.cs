using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    public class BinarySearchEngine : ISearchEngine
    {

        public bool Search(int[] Array, int x)
        {
            // to check how many loops.
            int loops = 0;
            int first = 0;
            int last = Array.Length - 1;

            while (first <= last)
            {
                // Find the middle number.
                int mid = (first + last) / 2;
                if (x == Array[mid])
                {
                    return true;
                }
                else if (x < Array[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
                loops++;
            }
            cycles(loops);
            return false;

        }

        public int cycles(int a)
        {

            Console.WriteLine($"The ammount of loops was {a}");
            return a;
        }

    }
}
