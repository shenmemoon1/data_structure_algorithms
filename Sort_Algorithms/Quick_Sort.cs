using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class Quick_Sort
    {
        public void quick_sort(int[] nums)
        {
            //to find the pivot value
            QuickSortRecursive(nums, 0, nums.Length - 1);
        }

        private void QuickSortRecursive(int[] nums, int left, int right)
        {
            //递归的停止条件
            if (left < right)
            {
                //获取基准数
                int pivot = Partition(nums, left, right);
                QuickSortRecursive(nums, left, pivot - 1);
                QuickSortRecursive(nums, pivot + 1, right);
            }
        } 

        private int Partition(int[] nums, int left, int right)
        {
            int i = left, j = right;
            int pivot = nums[left];

            //如果i>j 代表数组走完
            while (i < j)
            {
                //i不能越界 寻找大于基准数
                while (i < right && nums[i] <= pivot) i++;
                //寻找小于基准数
                while (nums[j] > pivot) j--;
                if (i < j)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }

            //最终替换第一个sorted的值和j
            (nums[left], nums[j]) = (nums[j], nums[left]);
            return j;
        }

    }
}
