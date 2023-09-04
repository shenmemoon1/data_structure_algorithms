using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_searches
{
    public class BinarySearch
    {
        //Question
        //给定一个长度为的数组 nums ，元素按从小到大的顺序排列，数组不包含重复元素。
        //请查找并返回元素 target 在该数组中的索引。若数组不包含该元素，则返回.


        public int FindIndex(int[] nums, int target)
        {
            //指针从两边开始
            int i = 0, j = nums.Length - 1;
            while (i<=j)
            {
                int m = i + (j - i) / 2;   // 计算中点索引 m
                if (nums[m] < target)      // 此情况说明 target 在区间 [m+1, j] 中
                    i = m + 1;
                else if (nums[m] > target) // 此情况说明 target 在区间 [i, m-1] 中
                    j = m - 1;
                else                       // 找到目标元素，返回其索引
                    return m;
            }
            
            //找不到
            return -1;
            
        }
    }
}
