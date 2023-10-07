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
            int n = A.Count; // 获取盘子数量，即列表A的元素个数
            Dfs(n, A, B, C); // 调用递归函数Dfs，将盘子从A移动到C，借助B
        }

        private static void Dfs(int n, List<int> src, List<int> buff, List<int> tar)
        {
            if (n == 1)
            {
                move(src, tar); // 如果只有一个盘子，直接将其从源柱(src)移动到目标柱(tar)
                return; // 返回，结束递归
            }

            Dfs(n - 1, src, tar, buff); // 递归调用，将n-1个盘子从源柱(src)移动到辅助柱(buff)，目标柱(tar)作为辅助
            move(src, tar); // 将最后一个盘子从源柱(src)移动到目标柱(tar)
            Dfs(n - 1, buff, src, tar); // 递归调用，将n-1个盘子从辅助柱(buff)移动到目标柱(tar)，源柱(src)作为辅助
        }

        private static void move(List<int> src, List<int> tar)
        {
            int pan = src[^1]; // 获取源柱(src)的顶部盘子
            src.RemoveAt(src.Count - 1); // 移除源柱(src)的顶部盘子
            tar.Add(pan); // 将盘子放置到目标柱(tar)的顶部
        }


        //resource:https://www.youtube.com/watch?v=YstLjLCGmgg
    }
}
