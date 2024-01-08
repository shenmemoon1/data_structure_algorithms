using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode125
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true; // An empty string or null is considered a palindrome
            }

            s = s.ToLower(); // Convert the string to lowercase for case-insensitive comparison
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                while (i < j && !char.IsLetterOrDigit(s[i]))
                {
                    i++; // Skip non-alphanumeric characters from the start
                }
                while (i < j && !char.IsLetterOrDigit(s[j]))
                {
                    j--; // Skip non-alphanumeric characters from the end
                }

                if (s[i] != s[j])
                {
                    return false; // If characters at positions i and j don't match, it's not a palindrome
                }
                i++;
                j--;
            }

            return true; // If the string passed all checks, it's a palindrome
        }
    }
}
