using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class BinarySearch
    {
        //基于二分的二分查找
        //给定一个长度为 n的有序数组 nums ，数组中所有元素都是唯一的，请查找元素 target 。
        public static int binarySearch(int[] nums, int target)
        {
            int size = nums.Length;
            // 调用深度优先搜索方法开始查找
            return Dfs(nums, 0, size - 1, target);
        }

        // 深度优先搜索方法，用于实际的二分查找
        private static int Dfs(int[] nums, int left, int right, int target)
        {
            // 如果左指针大于右指针，表示未找到目标值，返回 -1
            if (left > right)
            {
                return -1;
            }

            // 计算中间索引
            int mid = (left + right) / 2;

            // 如果中间元素大于目标值，继续在左侧搜索
            if (nums[mid] > target)
            {
                return Dfs(nums, left, mid - 1, target);
            }
            // 如果中间元素小于目标值，继续在右侧搜索
            else if (nums[mid] < target)
            {
                return Dfs(nums, mid + 1, right, target);
            }
            // 如果中间元素等于目标值，表示找到目标值，返回中间索引
            else
            {
                return mid;
            }
        }

    }
}
