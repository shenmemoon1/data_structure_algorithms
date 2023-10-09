using System;

namespace Greedy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = { 2, 5, 10, 20, 50, 100 };
            int counter = Greedy_CoinChange.CoinChangeGreedy(coins, 240);
            Console.WriteLine(counter);
        }
    }
}
