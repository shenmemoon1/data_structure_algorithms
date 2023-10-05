using System;

namespace DivideAndConquer
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //binary search
            int[] nums = { 1, 4, 6, 8, 22, 44, 66, 77 };
            int res = BinarySearch.binarySearch(nums, 22);
            Console.WriteLine(res);

            //bianry tree
            int[] preOrder = { 3, 9, 2, 1, 7 };
            int[] inOrder = { 9, 3, 1, 2, 7 };
            BinarySearchTreeQA.BuildTree(preOrder, inOrder);
        }
    }
}
