using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode13RomanToInteger
    {
        /*
         * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

            Symbol       Value
            I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000
         */

        public static int RomanToInteger(string s)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();
            hash.Add('I', 1);
            hash.Add('V', 5);
            hash.Add('X', 10);
            hash.Add('L', 50);
            hash.Add('C', 100);
            hash.Add('D', 500);
            hash.Add('M', 1000);

            //restult
            int res = 0;
            //loop each value and check if it is less than next value
            for (int i = 0; i < s.Length; i++)
            {
                if (i<s.Length-1 && hash[s[i]]< hash[s[i+1]])
                {
                    res -= hash[s[i]];
                }
                else
                {
                    res += hash[s[i]];
                }
            }

            return res;

        }
    }
}
