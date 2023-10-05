using System;

namespace DivideAndConquer
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 6, 8, 22, 44, 66, 77 };
            int res = BinarySearch.binarySearch(nums, 22);
            Console.WriteLine(res);
        }
    }
}
