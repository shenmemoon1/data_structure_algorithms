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
            if (string.IsNullOrEmpty(needle) || haystack == needle)
            {
                return -1;
            }

            if (haystack == needle)
            {
                return 0;
            }

            int res = -1;
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
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
