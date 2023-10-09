using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    /*
     * 给定一个共有 n 阶的楼梯，你每步可以上 1阶或者 2阶，但不能连续两轮跳1阶，请问有多少种方案可以爬到楼顶。
     */
    class ConstrainDpClimb
    {
        public static int ClimbingStairsConstraintDP(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            // 初始化 dp 表，用于存储子问题的解
            int[,] dp = new int[n + 1, 3];
            // 初始状态：预设最小子问题的解
            dp[1, 1] = 1;
            dp[1, 2] = 0;
            dp[2, 1] = 0;
            dp[2, 2] = 1;
            // 状态转移：从较小子问题逐步求解较大子问题
            for (int i = 3; i <= n; i++)
            {
                dp[i, 1] = dp[i - 1, 2];
                dp[i, 2] = dp[i - 2, 1] + dp[i - 2, 2];
            }
            return dp[n, 1] + dp[n, 2];
        }
    }
}
