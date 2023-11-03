using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    class FibonacciNumber
    {
        //using iterative
        public static int FibonacciIterative(int num)
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
        public static int FibonacciRecursive(int num)
        {
            if (num <= 1)
            {
                return num;
            }
            else
            {
                return FibonacciRecursive(num - 1) + FibonacciRecursive(num - 2);
            }

        }

        //using dp
        public static int FibonacciDP(int n)
        {
            //储存数值
            int[] f = new int[n + 2];
            //已知 0 1 的值
            f[0] = 0;
            f[1] = 1;

            //循环从2开始
            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }
    }
}
