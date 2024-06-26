﻿using System;
using BinaryTree;

namespace LeetcodeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------quetion 9----------------------");
            //Leetcode9Solution.IsPalindrome(121);
            //Leetcode9Solution.IsPalindrome(-121);
            Console.WriteLine(Leetcode9Solution.IsPalindrome(0));
            int[] nums = { 1, 2, 3 };
            Console.WriteLine(Leetcode78.Subsets(nums));
            Console.WriteLine(Leetcode22.GenerateParenthesis(3));
            Console.WriteLine("---------------qustion 13------------------------");
            string s = "LVIII";
            Leetcode13RomanToInteger.RomanToInteger(s);
            Console.WriteLine("-----------------quetion14-----------------------");
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine(Leetcode14LongestPrefix.LongestCommonPrefix(strs)); ;
            Console.WriteLine("-----------------question 27----------------------");
            int[] numbers = { 3, 2, 2, 3 };
            Console.WriteLine(Leetcode27RemoveElement.RemoveElement(numbers, 3));
            string haystack = "abc", needle = "c";
            Console.WriteLine(Leetcode28FindIndexOfFirstOccurrence.StrStr(haystack, needle));
            Console.WriteLine("--------------------58 question-------------------");
            string s1 = "Today is a nice day";
            Leetcode58LenofLastword.LengthOfLastWord(s1);
            Console.WriteLine("------------------66 question--------------------");
            int[] digits = { 1, 2, 4 };
            int[] digits2 = { 1, 8, 9 };

            Leecode66PlusOne.PlusOne(digits2);

            Console.WriteLine("------------------67 quetion----------------------");
            string a = "11", b = "1";
            Leetcode67AddBinary.AddBinary2(a, b);
            Console.WriteLine("----------------70 --------------------------------");
            Leetcode70ClimbingStair.ClimbStairs(5);
            Console.WriteLine("------------------88 question----------------------");
            int[] nums1 = { 1, 2, 3, 0, 0, 0 }, nums2 = { 2, 5, 6 };
            int m = 3, n = 3;
            Leetcode88MergeArray.Merge(nums1, m, nums2, n);
            Console.WriteLine("-----------------leetcode 119--------------------");
            Leetcode119Pascalll.GetRow(3);
            Console.WriteLine("-------------leetcode 121----------------------");
            Leetcode121.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Console.WriteLine("------------------leetcode206------------------");
            //create node
            ListNode node1 = new(1);
            ListNode node2 = new(2);
            ListNode node3 = new(3);
            ListNode node4 = new(4);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            Leetcode206.ReverseList(node1);
            Leetcode206.ReverseList2(node1);
            // Console.WriteLine("------------------leetcode234------------------");
            //create node
            ListNode n1 = new(1);
            ListNode n2 = new(2);
            ListNode n3 = new(2);
            ListNode n4 = new(1);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;

            Leetcode234.IsPalindrome(n1);


            Console.WriteLine("--------------------------leetcode543------------------");
            BinaryTree.TreeNode one = new(1);
            BinaryTree.TreeNode two = new(2);
            BinaryTree.TreeNode three = new(3);
            BinaryTree.TreeNode four = new(4);
            BinaryTree.TreeNode five = new(5);

            one.left = two;
            one.right = three;
            two.left = four;
            two.right = five;

            Leetcode543.DiameterOfBinaryTree(one);

            //Leetcode 5
            Console.WriteLine("-------------------------------------leetcode 5-----------------------------------------");

            string text = "cbb";

            Leetcode5.LongestPalindrome(text);
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Leetcode11.MaxArea(height);
        }
    }
}
