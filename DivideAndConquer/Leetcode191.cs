using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class Leetcode191
    {
        //solution one
        public static int HammingWeight(uint n)
        {
            int count = 0; // counter 1
                           //0 >> to 0 stop loop
            while (n > 0)
            {
                count += (int)(n & 1);
                n >>= 1;
            }

            return count;
        }

        //solution two(using divide and conquer)

        public static int HammingWeight2(uint n)
        {
            return CountOne(0, 32, n);
        }

        private static int CountOne(int left, int right, uint n)
        {
            // 中止条件
            if (left >= right || n == 0)
            {
                return (int)(n & 1); // 返回当前位是否为1
            }

            int halfSize = (left + right) / 2;
            uint leftHalf = n >> halfSize;
            uint rightHalf = n & ((1U << halfSize) - 1);

            int leftCount = CountOne(left, halfSize, leftHalf);
            int rightCount = CountOne(halfSize, right, rightHalf);

            return leftCount + rightCount;
        }

    }
}
