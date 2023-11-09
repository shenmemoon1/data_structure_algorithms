using System;
using static Greedy.BagValue;

namespace Greedy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = { 2, 5, 10, 20, 50, 100 };
            int counter = Greedy_CoinChange.CoinChangeGreedy(coins, 240);
            Console.WriteLine(counter);
            Console.WriteLine("-------------------------bag value-------------------");
            Item t1 = new(10,2);
            Item t2 = new(5, 3);
            Item t3 = new(15, 5);
            Item[] items = { t1, t2, t3 };

            Console.WriteLine(BagValue.ValueWeight(items, 7)) ;
        }
    }
}
