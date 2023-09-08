using System;

namespace Algorithms_searches
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing array
            int[] nums = { 1, 3, 6, 8,8,8,8, 12, 15, 23, 26, 31, 35 };
            BinarySearch binary = new BinarySearch();
            int res = binary.FindIndex(nums, 6);
            int res2 = binary.FindIndex2(nums, 6);
            Console.WriteLine(res);
            Console.WriteLine(res2);


            Console.WriteLine("------------binary inserction------------");
            BinaryInserction binary1 = new BinaryInserction();
            int res3 = binary1.binaryInsert(nums, 5);
            Console.WriteLine(res3);
            int res4 = binary1.binaryInsert2(nums, 8);
            Console.WriteLine(res4);

            int res5 = binary1.binarySearchLeftEdge(nums,5);

            Console.WriteLine(res5);
            int res6 = binary1.binarySearchRightEdge(nums, 5);

            Console.WriteLine(res5);
        }
    }
}
