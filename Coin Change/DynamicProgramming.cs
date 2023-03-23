using System;
using System.Collections.Generic;
using System.Text;

namespace CoinChange
{
    class DynamicProgramming
    {
        public int getNumberOfWays(int N, int[] Coins)
        {
            // Create the ways array to 1 plus the amount
            // to stop overflow
            int[] ways = new int[(int)N + 1];

            // Set the first way to 1 because its 0 and
            // there is 1 way to make 0 with 0 coins
            ways[0] = 1;

            // Go through all of the coins
            for (int i = 0; i < Coins.Length; i++)
            {

                // Make a comparison to each index value
                // of ways with the coin value.
                for (int j = 0; j < ways.Length; j++)
                {
                    if (Coins[i] <= j)
                    {

                        // Update the ways array
                        ways[j] += ways[(int)(j - Coins[i])];
                    }
                }
            }

            // return the value at the Nth position
            // of the ways array.
            return ways[(int)N];
        }
    }
}
