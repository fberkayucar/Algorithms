using System;
using System.Collections;
using System.Linq;

namespace CoinChange
{
    class Program
    {
        static GreedyApproach sort = new GreedyApproach();
        static DynamicProgramming dynamic = new DynamicProgramming();
        static void Main(string[] args)
        {
            int change = 0;
            Console.WriteLine("1 = Task 1 , 2 = Task 2, 3 = task 3");
            change = Convert.ToInt16(Console.ReadLine());
            switch (change)
            {
                case 1:
                    Gredd1();
                    break;
                case 2:
                    gredd2();
                    break;
                case 3:
                    dynamic3();
                    break;
                default:
                    break;
            }
        }
        static void Gredd1()
        {
            int[] Coins = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            int input = 0;
            int howMany = 0;
            Console.WriteLine("Write your coin to change: ");
            input = Convert.ToInt16(Console.ReadLine());
            if (input < 0)
            {
                Console.Clear();
                Console.WriteLine("Write positive integer");
                return;
            }
            sort.changeCoinn(Coins, input, howMany);
        }
        static void gredd2()
        {
            int input = 0;
            int howMany = 0;
            bool check1 = false;
            int sizeOfArray = 0;
            int i = 0;
            var money = new int[6];
            while (sizeOfArray <= 6)
            {
                Console.WriteLine("Write Your Coins That You Have");
                input = Convert.ToInt16(Console.ReadLine());
                money[i] = input;
                sizeOfArray++;
                i++;
                if (input == 1)
                {
                    check1 = true;
                }
                if (sizeOfArray == 6)
                {
                    break;
                }
            }
            foreach (var allMoney in money)
            {
                if (allMoney < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Coin should be positive integer");
                }
            }
            if (check1 == false)
            {
                Console.Clear();
                Console.WriteLine("One coin must have value of 1");
            }
            Console.WriteLine("Change Coin to: ?");
            int key = int.Parse(Console.ReadLine());
            if (key < 0)
            {
                Console.Clear();
                Console.WriteLine("Input should be positive integer!");
                return;
            }
            if (key == 0)
            {
                Console.Clear();
                Console.WriteLine("No need money (:");
                return;
            }
            sort.changeCoinn(money, key, howMany);
        }
        static void dynamic3()
        {
            int input = 0;
            bool check1 = false;
            int sizeOfArray = 0;
            int i = 0;
            var money = new int[6];
            while (sizeOfArray <= 6)
            {
                Console.WriteLine("Write Your Coins That You Have");
                input = Convert.ToInt16(Console.ReadLine());
                money[i] = input;
                sizeOfArray++;
                i++;
                if (input == 1)
                {
                    check1 = true;
                }
                if (sizeOfArray == 6)
                {
                    break;
                }
            }
            foreach (var allMoney in money)
            {
                if (allMoney < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Coin should be positive integer");
                }
            }
            if (check1 == false)
            {
                Console.Clear();
                Console.WriteLine("One coin must have value of 1");
            }
            Console.WriteLine("Change Coin to: ?");
            int key = int.Parse(Console.ReadLine());
            if (key < 0)
            {
                Console.Clear();
                Console.WriteLine("Input should be positive integer!");
                return;
            }
            if (key == 0)
            {
                Console.Clear();
                Console.WriteLine("No need money (:");
                return;
            }
            int result = dynamic.getNumberOfWays(key, money);
            Console.WriteLine(result);
        }
    }
}
