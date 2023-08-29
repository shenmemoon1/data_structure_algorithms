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
        static List<int> maxHeap = new List<int>();
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

        //peek
        static int peek()
        {
            return maxHeap[0];
        }

        //push val
        static void push(int val)
        {
            maxHeap.Add(val);
            //底部到顶堆化
            shiftUp(size() - 1);
        }

        static void shiftUp(int val)
        {
            while (true)
            {
                //i 的父节点
                int p = parent(val);

                if (p<0 || maxHeap[val] < maxHeap[p])
                {
                    break;
                }
                //交换两个节点
                swap(p, val);
                val = p;
            }
            
        }
        //替换元素
        static void swap(int a,int b)
        {
            int temp = maxHeap[a];
            maxHeap[a] = maxHeap[b];
            maxHeap[b]= temp;
        }

        static int size()
        {
            return maxHeap.Count;
        }

        static int pop()
        {
            //判断空处理
            if (isEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            //交换首位节点
            swap(size() - 1, 0);
            //删除节点
            int val = maxHeap.Last();
            maxHeap.Remove(val);
            //顶到底部堆化
            shiftDown(0);
            return val;
        }

        static void shiftDown(int i)
        {
            while (true)
            {
                //判断节点 i l r最大的节点 max
                int l = left(i), r = right(i), max = i;
                if (l < size() && maxHeap[l] > maxHeap[max])
                {
                    max = l;
                }
                if (r < size() && maxHeap[r] > maxHeap[max])
                {
                    max = r;
                }
                //如果超过最大和越过节点 则结束堆
                if (max == i) break;
                //交换节点
                swap(max, i);
                //循环向下堆化
                i = max;
            }
        }

        static bool isEmpty()
        {
            return maxHeap.Count == 0;
        }

    }
}
