using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    class DPClimbStair_dfs_memory
    {
        public static int ClimbStairDfs_Mem(int n)
        {
            //mem[i] 记录i阶的方案总数，-1代表无记录
            int[] mem = new int[n+1];

            //初始化-1 无记录
            Array.Fill(mem, -1);
            return Dfs(mem, n);
        }

        private static int Dfs(int[] mem, int n)
        {
            if (n == 1 || n==2)
            {
                return n;
            }

            if (mem[n] != -1)
            {
                return mem[n];
            }

            return Dfs(mem, n - 1) + Dfs(mem, n - 2);
        }
    }
}
