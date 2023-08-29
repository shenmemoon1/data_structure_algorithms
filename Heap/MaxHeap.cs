using System;
using System.Collections.Generic;
using System.Linq;

namespace Heap
{
    public class MaxHeap
    {
        public List<int> maxHeap;
        /* 构造函数，根据输入列表建堆 */
        public MaxHeap(IEnumerable<int> nums)
        {
            // 将列表元素原封不动添加进堆
            maxHeap = new List<int>(nums);
            // 堆化除叶节点以外的其他所有节点
            var size = parent(this.size() - 1);
            for (int i = size; i >= 0; i--)
            {
                shifDown(i);
            }
        }

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
        public int left(int i)
        {
            return 2 * i + 1;
        }
        //右子节点
        public  int right(int i)
        {
            return 2 * i + 2;
        }
        //父节点
        public  int parent(int i)
        {
            return (i - 1) / 2; // 向下整除
        }

        //peek
        public int peek()
        {
            return maxHeap[0];
        }

        //push val
        public void push(int val)
        {
            maxHeap.Add(val);
            //底部到顶堆化
            shifUp(size() - 1);
        }

        public void shifUp(int val)
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
        public void swap(int a,int b)
        {
            int temp = maxHeap[a];
            maxHeap[a] = maxHeap[b];
            maxHeap[b]= temp;
        }

        public int size()
        {
            return maxHeap.Count;
        }

        public int pop()
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
            shifDown(0);
            return val;
        }

         public void shifDown(int i)
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
                if (i == max) break;
                //交换节点
                swap(max, i);
                //循环向下堆化
                max = i;
            }
        }

        public bool isEmpty()
        {
            return maxHeap.Count == 0;
        }

        public List<int> print()
        {
            return maxHeap;
        }

    }
}
