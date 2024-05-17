using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode5
    {
        public static string LongestPalindrome(string s)
        {
            List<string> longSub = new List<string>();

            FindSub(longSub, s);

            string longestPalindrome = "";
            foreach (var sub in longSub)
            {
                if (sub.Length > longestPalindrome.Length)
                {
                    longestPalindrome = sub;
                }
            }

            return longestPalindrome;
        }

        public static void FindSub(List<string> list, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = i; j < text.Length; j++)
                {
                    if (sb.ToString().Contains(text[j]))
                    {

                        sb.Append(text[j]);
                        break;
                    }
                    sb.Append(text[j]);
                }
                list.Add(sb.ToString());
            }
        }
    }
}
