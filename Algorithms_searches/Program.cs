using System;

namespace Algorithms_searches
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing array
            int[] nums = { 1, 3, 6, 8, 12, 15, 23, 26, 31, 35 };
            BinarySearch binary = new BinarySearch();
            int res = binary.FindIndex(nums, 6);
            int res2 = binary.FindIndex2(nums, 6);
            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}
