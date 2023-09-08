using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_searches
{
    class HashOptz
    {
        /*
         * Question
         * 给定一个整数数组 nums 和一个目标元素 target ，请在数组中搜索“和”为 target 的两个元素，并返回它们的数组索引。返回任意一个解即可。
         */
           
        public int[] twoSumBruteForce(int[] nums, int target)
        {
            int size = nums.Length;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    if (nums[i]+nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }

        //using hashTable optimazation

        public int[] twoSumHashTable(int[] nums, int target)
        {
            int size = nums.Length;
            Dictionary<int, int> dic = new();
            for (int i = 0; i < size; i++)
            {
                int remain = target - nums[i];
                if (dic.ContainsKey(remain))
                {
                    return new int[] {dic[remain], i };
                }

                dic.Add(nums[i], i);
            }

            return Array.Empty<int>();
        }

    }
}
