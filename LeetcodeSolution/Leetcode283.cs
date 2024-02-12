using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode283
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0) return;
            List<int> list = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    list.Add(nums[i]);
                    nums[i] = 0;
                }
            }

            for (int j = 0; j < list.Count; j++)
            {
                nums[j] = list[j];
            }

        }

        //第二种思路 
        //! 就是使用sort的方式， 遍历每一个元素 然后使用替换来把非0换到前面
    }
}
