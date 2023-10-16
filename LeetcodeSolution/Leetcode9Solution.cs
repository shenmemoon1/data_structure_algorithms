using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode9Solution
    {
        //solution one 
        public static bool IsPalindrome(int x)
        {
            //变成string （类似数组可以进行操作）
            string xStr = x.ToString();
            //左边游标
            int left = 0;
            //右边游标
            int right = xStr.Length -1;

            //当都循环结束 代表没有false 返回true
            while (left > right)
            {
                //左游标和右侧进行比较
                if (xStr[left] != xStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }


        //solution two
        public bool IsPalindrome2(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            //test reverse == x;
            int reverse = 0;
            int original = x;

            while (x > 0)
            {
                int digital = x % 10;
                reverse = reverse * 10 + digital;
                x /= 10;
            }

            return reverse == original ? true : false;
        }


        //solution three using divide conquer
        public bool IsPalindrome3(int x)
        {
            string xStr = x.ToString();
            int left = 0;
            int right = xStr.Length - 1;
            return IsPalindromeHelper(left, right, xStr);
        }

        private bool IsPalindromeHelper(int left, int right, string str)
        {
            if (left >= right)
            {
                return true; // Base case: If we've checked all characters, it's a palindrome.
            }
            if (str[left] != str[right])
            {
                return false; // If characters don't match, it's not a palindrome.
            }
            // Recursively check the substring between left and right.
            return IsPalindromeHelper(left + 1, right - 1, str);
        }
    }
}
