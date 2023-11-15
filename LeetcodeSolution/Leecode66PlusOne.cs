using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leecode66PlusOne
    {
        public static int[] PlusOne(int[] digits)
        { 
            int n = digits.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            // If we're here, it means there was a carry in the most significant digit
            int[] result = new int[n + 1];
            result[0] = 1;

            return result;
        }

    }
}
