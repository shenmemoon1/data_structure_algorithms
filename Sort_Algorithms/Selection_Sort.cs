using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class Selection_Sort
    {
        /*
         * 「选择排序 selection sort」的工作原理非常直接：开启一个循环，每轮从未排序区间选择最小的元素，将其放到已排序区间的末尾。
         */
        public void selectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                int k = i;
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[k])
                    {
                        k = j;
                    }
                }

                (nums[k], nums[i]) = (nums[i], nums[k]);
            }

        }
    }
}
