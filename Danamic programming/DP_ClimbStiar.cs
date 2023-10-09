using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    class DP_ClimbStiar
    {
        public static int ClimbStairDP(int n)
        {
            //中止条件
            if (n ==1 || n==2)
            {
                return n;
            }
            // 初始化 dp 表，用于存储子问题的解
            int[] dp = new int[n+1];

            dp[0] = 1;
            dp[1] = 2;

            for (int i = 3; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n]; 
            
            
        }

        //空间优化
        /* 爬楼梯：空间优化后的动态规划 */
        int ClimbingStairsDPComp(int n)
        {
            if (n == 1 || n == 2)
                return n;
            int a = 1, b = 2;
            for (int i = 3; i <= n; i++)
            {
                int tmp = b;
                b = a + b;
                a = tmp;
            }
            return b;
        }
    }
}
