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
        public int HammingWeight(uint n)
        {
            int count = 0; // counter 1
                           //0 >> to 0 stop loop
            while (n > 0)
            {
                count += (int)(n & 1);
                n = n >> 1;
            }

            return count;
        }

        //solution two(using divide and conquer)
    }
}
