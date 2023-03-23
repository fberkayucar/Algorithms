using System;
using System.Collections.Generic;
using System.Text;

namespace CoinChange
{
    class GreedyApproach
    {
        public void changeCoinn(int[] Coins, int change, int howMany = 0)
        {
            for (int i = Coins.Length - 1; i >= 0; i--)
            {
                if (Coins[i] > change)
                {
                    continue;
                }
                howMany = change / Coins[i];
                change = change % Coins[i];
                Console.WriteLine($"{howMany} {Coins[i]}");
            }
        }
    }
}
