using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrentPriorityQueue;

namespace Heap
{
    class embdedHeap
    {
        /* 初始化堆 */
        // 初始化小顶堆
        //堆满足完全二叉树条件 =》 使用数组实现
        //规则
        /*
         * 给定索引 i
         ，其左子节点索引为  2i+1
         ，右子节点索引为  2i+2
         ，父节点索引为  (i-1)/2
        （向下取整）。当索引越界时，表示空节点或节点不存在
         */
        //左子节点
        static int left(int i)
        {
            return 2 * i + 1;
        }
        //右子节点
        static int right(int i)
        {
            return 2 * i + 2;
        }
        //父节点
        static int parent(int i)
        {
            return (i - 1) / 2; // 向下整除
        }

    }
}
