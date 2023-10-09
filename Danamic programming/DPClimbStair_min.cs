using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    class DPClimbStair_min
    {
        /*
         * 问题：
         * 给定一个楼梯，你每步可以上 1阶或者 2阶，每一阶楼梯上都贴有一个非负整数，表示你在该台阶所需要付出的代价。给定一个非负整数数组 cost
         * ，其中 cost[i]表示在第 i个台阶需要付出的代价，cost[0]为地面起始点。请计算最少需要付出多少代价才能到达顶部？
         * 
         * 测试例子：
         * 1， 2，  3
         * 1， 10， 1
         */

        //可以看出到3的最小代价是2

        public static int MinCost_Stair(int[] cost)
        {
            int n = cost.Length - 1; // 获取楼梯的总层数，减1是因为数组索引从0开始。

            if (n == 1 || n == 2)
            {
                return cost[n]; // 如果楼梯只有1层或2层，直接返回对应的代价，因为无需进行动态规划。
            }

            // 初始化dp表，用于存储子问题的解
            int[] dp = new int[n + 1];

            // 初始化状态，预计最小子问题解
            dp[1] = cost[1]; // 到达第1层的最小代价就是第1层的代价
            dp[2] = cost[2]; // 到达第2层的最小代价就是第2层的代价

            // 开始动态规划，从第3层开始计算
            for (int i = 3; i <= n; i++)
            {
                // 状态转移方程：到达第i层的最小代价等于前一层或前两层中的最小代价，再加上当前层的代价
                dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
            }

            return dp[n]; // 返回到达顶部台阶的最小代价。

        }
    }
}
