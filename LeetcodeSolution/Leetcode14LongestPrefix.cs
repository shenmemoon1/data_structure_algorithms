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
            string res = "";
            int len = strs.Length;
            int count = 3;
            for (int i = 0; i < len; i++)
            {
                //获取第一个数组元素的第一个元素
                char findLetter = strs[0][i];
                for (int j = 1; j < strs[0].Length j++)
                {
                    if(strs[j][i] != findLetter)
                    {
                        count--;
                        break;
                    }
                }
                if(count == 3)
                {
                    res += findLetter;
                }
            }
            return res;

        }
    }
}
