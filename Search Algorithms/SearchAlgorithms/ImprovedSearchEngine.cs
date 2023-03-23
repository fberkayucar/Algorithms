using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    public class ImprovedSearchEngine : ISearchEngine
    {
        public bool Search(int[] Array, int x)
        {
            for (int i = 0; i < Array.Length; i++)
            {

                if (x == Array[i])
                {
                    // If key is first element
                    if (i == 0)
                        return true;

                    int temp = Array[i];
                    Array[i] = Array[i - 1];
                    Array[i - 1] = temp;
                    return true;
                }
            }
            return false;
        }
    }
}
