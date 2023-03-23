using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    public class ImprovedWithSentinelSearchEngine : ISearchEngine 
    {
        public bool Search(int[] Array, int x)
        {
            int last = Array[Array.Length - 1];

            Array[Array.Length - 1] = x;
            int i = 0;

            while (Array[i] != x)
                i++;
            Array[Array.Length - 1] = last;

            if ((i < Array.Length - 1) || (Array[Array.Length - 1] == x))
                return true;
            else
                return false;
        }
    }
}
