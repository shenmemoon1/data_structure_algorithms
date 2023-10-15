using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class Leetcode53MaxSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            return MaxNum(0, nums.Length - 1, nums);
        }

        private static int MaxNum(int left, int right, int[] nums)
         {
            if (left == right)
            {
                return nums[left];
            }

            int mid = (left + right) / 2;

            int leftVal = MaxNum(left, mid, nums);
            int rightVal = MaxNum(mid + 1, right, nums);

            int mergeVal = Merge(left, mid, right, nums);

            return Math.Max(Math.Max(leftVal, rightVal), mergeVal);
        }

        private static int Merge(int left, int mid, int right, int[] nums)
        {
            int maxLeftSuffixSum = int.MinValue;
            int currentSum = 0;
            for (int i = mid; i >= left; i--)
            {
                currentSum += nums[i];
                maxLeftSuffixSum = Math.Max(maxLeftSuffixSum, currentSum);
            }

            int maxRightPrefixSum = int.MinValue;
            currentSum = 0;
            for (int i = mid + 1; i <= right; i++)
            {
                currentSum += nums[i];
                maxRightPrefixSum = Math.Max(maxRightPrefixSum, currentSum);
            }

            return Math.Max(maxLeftSuffixSum + maxRightPrefixSum, Math.Max(maxLeftSuffixSum, maxRightPrefixSum));
        }

        public static int MaxSubArray2(int[] nums)
        {
            int maxSum = nums[0];  // 用于跟踪最大子数组和
            int currentSum = nums[0];  // 用于跟踪当前子数组和

            for (int i = 1; i < nums.Length; i++)
            {
                // 将当前元素添加到当前子数组和
                currentSum = Math.Max(nums[i], currentSum + nums[i]);

                // 更新最大子数组和
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
