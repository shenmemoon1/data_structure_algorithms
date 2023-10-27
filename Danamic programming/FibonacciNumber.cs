using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    class FibonacciNumber
    {
        //using dp
        public static int FibonacciDP(int num)
        {
            int a = 0, b = 1, c = 0;

            //return the frist fibonacci number
            if (num == 0)
                return a;
            for (int i = 2; i <= num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

        //using recursive
        public static int Fibonacci2(int num)
        {
            if (num <= 1)
            {
                return num;
            }
            else
            {
                return Fibonacci2(num - 1) + Fibonacci2(num - 2);
            }


        }
    }
}
