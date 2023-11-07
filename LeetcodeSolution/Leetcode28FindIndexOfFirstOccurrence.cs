using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode28FindIndexOfFirstOccurrence
    {
        public static int StrStr(string haystack, string needle)
        {
            int res = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                string substr = haystack.Substring(i, needle.Length);
                //0 - 2
                if (substr == needle)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
    }
}
