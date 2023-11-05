using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode14LongestPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            string res = "";
            int len = strs[0].Length;


            for (int i = 0; i < len; i++)
            {
                char findLetter = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != findLetter)
                    {
                        return res;
                    }
                }
                res += findLetter;
            }
            return res;


        }
    }
}
