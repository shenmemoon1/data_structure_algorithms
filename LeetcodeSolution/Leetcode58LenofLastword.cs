using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode58LenofLastword
    {
        public static int LengthOfLastWord(string s)
        {
            //seperate s to array and keey char except empty space
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words[words.Length - 1].Length;
        }
    }
}
