using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class Bubble_Sort
    {
        public void bubble_sort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                //优化
                bool flag = false; // 初始化标志位
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        (nums[i], nums[j]) = (nums[j], nums[i]);
                        flag = true; //记录交换元素
                    }

                }
                if (!flag) break;     // 此轮冒泡未交换任何元素，直接跳出
            }
        }
    }
}
