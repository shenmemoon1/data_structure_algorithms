using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    class CoinChange
    {
        //给定不同面额的硬币和一个目标金额，编写一个函数来计算凑出目标金额所需的最少硬币数量。如果无法凑出目标金额，则返回 -1
        public static int LeastCoinChange(int[] coins, int amount)
        {
            //already know 0 = 0
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (i - coin >= 0)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];

        }

    }
}
