using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class HeapSort
    {
        //堆排序
        /*输入数组并建立大顶堆。完成后，最大元素位于堆顶。
        将堆顶元素（第一个元素）与堆底元素（最后一个元素）交换。完成交换后，堆的长度减 ，已排序元素数量加 1
         。
        从堆顶元素开始，从顶到底执行堆化操作（Sift Down）。完成堆化后，堆的性质得到修复。
        循环执行第 2. 和 3. 步。循环 n -1轮后，即可完成数组排序。*/
        public static void HeapSor(int[] nums)
        {
            //nums-length /2 -1 获取最后一个非子节点
            for (int i = nums.Length /2 -1; i >= 0; i--)
            {
                //和左右子节点对比
                ShiftDown(nums, nums.Length, i);
            }

            for (int i = nums.Length - 1; i > 0; i--)
            {
                (nums[i], nums[0]) = (nums[0], nums[i]);
                ShiftDown(nums, i, 0);
            }
        }

        private static void ShiftDown(int[] nums, int length, int i)
        {
            while (true)
            {
                //左子节点
                int left = 2 * i + 1;
                //右子节点
                int right = 2 * i + 2;
                //最大值自身
                int max = i;
                //left 位置的值 大于 max 也就是i 的值 max=left
                if (left < length && nums[left] > nums[max])
                {
                    max = left;
                }
                //同上
                if(right < length && nums[right] > nums[max])
                {
                    max = right;
                }
                //如果最大值等于自身 直接跳出循环
                if (max == i)
                {
                    break;
                }

                //当上面的条件left or rigth 大于非子节点 进行替换
                (nums[max], nums[i]) = (nums[i], nums[max]);
                //i = max的位置
                i = max;


            }
        }
    }
}
