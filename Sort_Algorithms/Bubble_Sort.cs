using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class Bubble_Sort
    {
        public void bubble_sort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        (nums[i], nums[j]) = (nums[j], nums[i]);
                    }
                }
            }
        }
    }
}
