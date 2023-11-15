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
            string haystack = "abc", needle = "c";
            Console.WriteLine(Leetcode28FindIndexOfFirstOccurrence.StrStr(haystack,needle));
            Console.WriteLine("--------------------58 question-------------------");
            string s1 = "Today is a nice day";
            Leetcode58LenofLastword.LengthOfLastWord(s1);
            Console.WriteLine("------------------66 question--------------------");
            int[] digits = { 1, 2, 4 };
            int[] digits2 = {1, 8,9 };

            Leecode66PlusOne.PlusOne(digits2);

            Console.WriteLine("------------------67 quetion----------------------");
            string a = "11", b = "1";
            Leetcode67AddBinary.AddBinary2(a, b);
        }
    }
}
