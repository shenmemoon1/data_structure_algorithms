using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode27RemoveElement
    {
        public static int RemoveElement(int[] nums, int val)
        {
            //重置新的下标
            int newIndex = 0;
            //循环检测不等于val得值
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    
                    nums[newIndex] = nums[i];
                    newIndex++;
                }
            }
            return newIndex;
        }
    }
}
