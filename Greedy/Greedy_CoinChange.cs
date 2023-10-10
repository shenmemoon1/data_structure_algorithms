using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    class Greedy_CoinChange
    {
        /*
             * 给定n种硬币,第i种硬币的面值为coins[i-1],目标金额为amt,每种硬币可以重复选取,
             * 问能够凑出目标金额的最少硬币个数。如果无法凑出目标金额则返回-1。
             */
        public static int CoinChangeGreedy(int[] coins, int amt)
        {
            //假设 coins 列表有序
            int i = coins.Length - 1;
            int count = 0;
            // 循环进行贪心选择，直到无剩余金额
            while (amt > 0)
            {
                // 找到小于且最接近剩余金额的硬币
                while (i>0 && coins[i] > amt)
                {
                    i--;
                }
                //选择coin[i]
                amt -= coins[i];
                count++;
            }
            // 若未找到可行方案，则返回 -1
            return amt == 0? count:-1;
        }
    }
}
