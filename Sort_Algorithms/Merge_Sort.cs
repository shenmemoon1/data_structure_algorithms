using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class Merge_Sort
    {
        public void MergeSort(int[] nums)
         {
            MergeRecursive(nums, 0, nums.Length -1);
        }

        private static void MergeRecursive(int[] nums, int left, int right)
        {
            if (left >= right) return;  // 当子数组长度为 1 时终止递归
            int mid = (left + right) / 2;  // 计算中点
            MergeRecursive(nums, left, mid);  // 递归左子数组
            MergeRecursive(nums, mid + 1, right); // 递归右子数组
            // 合并阶段
            Merge(nums, left, mid, right);
        }

        private static void Merge(int[] nums, int left, int mid, int right)
        {
            int[] tmp = nums[left..(right + 1)];
            int leftStart = left - left, leftEnd = mid - left;
            int rightStart = mid+1 - left, rightEnd = right - left;
            int i = leftStart, j = rightStart;
            for (int k = left; k <= right; k++)
            {
                // 若“左子数组已全部合并完”，则选取右子数组元素，并且 j++
                if (i > leftEnd)
                    nums[k] = tmp[j++];
                // 否则，若“右子数组已全部合并完”或“左子数组元素 <= 右子数组元素”，则选取左子数组元素，并且 i++
                else if (j > rightEnd || tmp[i] <= tmp[j])
                    nums[k] = tmp[i++];
                // 否则，若“左右子数组都未全部合并完”且“左子数组元素 > 右子数组元素”，则选取右子数组元素，并且 j++
                else
                    nums[k] = tmp[j++];
            }
        }

       
    }
}
