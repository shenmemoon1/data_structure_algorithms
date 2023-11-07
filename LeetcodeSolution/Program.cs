using System;

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
            Console.WriteLine(Leetcode27RemoveElement.RemoveElement(numbers,3));
            string haystack = "hello", needle = "ll";
            Console.WriteLine(Leetcode28FindIndexOfFirstOccurrence.StrStr(haystack,needle));
        }
    }
}
