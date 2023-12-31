﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_searches
{
    class BinaryInserction
    {

        /*
         * Question
         * 给定一个长度为的有序数组 nums 和一个元素 target ，数组不存在重复元素。
         * 现将 target 插入到数组 nums 中，并保持其有序性。若数组中已存在元素 target ，
         * 则插入到其左方。请返回插入后 target 在数组中的索引
         */

        public int binaryInsert(int[] nums, int target)
        {
            int i = 0, j = nums.Length;
            while (i<j)
            { 
                int m = i + (j - i) / 2;
                if (nums[m] < target)      // 此情况说明 target 在区间 [m+1, j] 中
                    i = m + 1;
                else if (nums[m] > target) // 此情况说明 target 在区间 [i, m-1] 中
                    j = m;
                else                       // 找到目标元素，返回其索引
                    return m;
            }
            return i;
        }

        public int  binaryInsert2(int[] nums, int target)
        {
            int i = 0, j = nums.Length - 1; // 初始化双闭区间 [0, n-1]
            while (i <= j)
            {
                int m = i + (j - i) / 2; // 计算中点索引 m
                if (nums[m] < target)
                {
                    i = m + 1; // target 在区间 [m+1, j] 中
                }
                else if (nums[m] > target)
                {
                    j = m - 1; // target 在区间 [i, m-1] 中
                }
                else
                {
                    j = m - 1; // 首个小于 target 的元素在区间 [i, m-1] 中
                }
            }
            // 返回插入点 i
            return i;
        }
        /*
         * Question
         * 给定一个长度为n的有序数组 nums ，数组可能包含重复元素。请返回数组中最左一个元素 target 的索引。若数组中不包含该元素，则返回 -1
         */
        /* 二分查找最左一个 target */
        public int binarySearchLeftEdge(int[] nums, int target)
        {
            // 等价于查找 target 的插入点
            int i = binaryInsert2(nums, target);
            // 未找到 target ，返回 -1
            if (i == nums.Length || nums[i]!=target)
            {
                return -1;
            }
            //找到target 返回索引 i
            return i;
        }

        /* 二分查找最右一个 target */
        public int binarySearchRightEdge(int[] nums, int target)
        {
            int i = binaryInsert2(nums, target + 1); 
            // j 指向最右一个 target ，i 指向首个大于 target 的元素
            int j = i - 1;
            // 未找到 target ，返回 -1
            if (j == -1 || nums[j] != target)
            {
                return -1;
            }
            // 找到 target ，返回索引 j
            return j;
        }
    }


}
