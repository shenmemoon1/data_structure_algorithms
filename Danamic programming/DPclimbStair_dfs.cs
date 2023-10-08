using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danamic_programming
{
    class DPclimbStair_dfs
    {
        //爬楼梯搜索
        public static int ClimbStairDFS(int n)
        {
            //传入n
            return Dfs(n);
        }

        private static int Dfs(int i)
        {
            //中止条件
            if (i == 1 || i ==2)
            {
                return i;
            }

            //最后的阶梯等于它的前两个阶梯的总和
            return Dfs(i - 1) + Dfs(i - 2);
        }
    }
}
