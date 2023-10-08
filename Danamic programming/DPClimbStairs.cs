using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    class DPClimbStairs
    {
        //给定一个共有 n阶的楼梯，你每步可以上1阶或者2阶，请问有多少种方案可以爬到楼顶。
        public static int ClimbStairBacktrack(int n)
        {
            List<int> choices = new() { 1, 2 };// 可选择向上爬 1 或 2 阶
            int state = 0;// 从第 0 阶开始爬
            List<int> res = new() { 0 }; // 使用 res[0] 记录方案数量
            Backtrack(choices, state, n, res);
            return res[0];

        }

        private static void Backtrack(List<int> choices, int state, int n, List<int> res)
        {
            //当爬到N阶 方案数列+1
            if (state == n)
            {
                res[0]++;
            }

            //遍历所有选择
            foreach (int choice in choices)
            {
                if (state + choice > n)
                {
                    break;
                }

                //尝试其他
                Backtrack(choices, state + choice, n, res);
            }
        }
    }
}
