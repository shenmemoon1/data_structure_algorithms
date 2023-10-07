using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class DCHanoiTower
    {
        /*
         * 给定三根柱子，记为 A、B 和 C 。起始状态下，柱子 A 上套着 个圆盘，它们从上到下按照从小到大的顺序排列。我们的任务是要把这
         * 个圆盘移到柱子 C 上，并保持它们的原有顺序不变。在移动圆盘的过程中，需要遵守以下规则。
         * 圆盘只能从一个柱子顶部拿出，
         * 从另一个柱子顶部放入。
         * 小圆盘必须时刻位于大圆盘之上。
         */

        public static void solveHanota(List<int> A, List<int> B, List<int> C)
        {
            int n = A.Count;
            Dfs(n, A, B, C);
        }

        private static void Dfs(int n, List<int> src, List<int> buff, List<int> tar)
        {
            if(n == 1)
            {
                move(src, tar);
                return;
            }

            Dfs(n - 1, src, tar, buff);
            move(src, tar);
            Dfs(n - 1, buff, src, tar);

        }

        private static void move(List<int> src, List<int> tar)
        {
            int pan = src[^1];
            src.RemoveAt(src.Count - 1);
            tar.Add(pan);
        }
    }
}
