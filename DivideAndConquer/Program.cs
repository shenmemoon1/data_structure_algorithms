using System;
using System.Collections.Generic;

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

            Console.WriteLine("------------------------------------------");
            List<int> A = new List<int> { 1, 2, 3, 4, 5 };
            List<int> B = new List<int>();
            List<int> C = new List<int>();
            DCHanoiTower.solveHanota(A, B, C);
            foreach (int value in C)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(HanoiStepCalculate.HanoiCal(10));

            Console.WriteLine("--------------------Leetcode 169-------------------------");
            int[] nums2 = { 3, 2, 3 };
            Console.WriteLine(Leetcode169MajorityElement.MajorityElement(nums2));
            Leetcode169MajorityElement.MajorityElement2(nums2);

            Console.WriteLine("-------------------------Leetcode 190-------------------------------");
            Console.WriteLine(Leetcode190ReverseBits.reverseBits(0b11111111111111111111111111111101));
            Console.WriteLine(Leetcode190ReverseBits.reverseBits3(0b11111111111111111111111111111101));
            Console.WriteLine("-------------------------------Leetcode 23--------------------------------");
            // 创建3个已排序链表
            ListNode list1 = new ListNode(1, new ListNode(4, new ListNode(5)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode list3 = new ListNode(2, new ListNode(6));
            ListNode[] lists = new ListNode[] { list1, list2, list3 };
            Leetcode23MergekSortedLists.MergeKLists(lists);

            Console.WriteLine("-----------------------------53-------------------------------------");
            int[] nums3 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Leetcode53MaxSubarray.MaxSubArray(nums3);
            Leetcode53MaxSubarray.MaxSubArray2(nums3);

        }
    }
}
