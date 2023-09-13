using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class quick
    {
        public void quicks(int[] nums)
        {
            recursive(nums, 0, nums.Length - 1);
        }

        private void recursive(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int part = partition(nums, left, right);
                recursive(nums, left, part - 1);
                recursive(nums, part + 1, right);
            }
        }

        private int partition(int[] nums, int left, int right)
        {
            int i = left, j = right;
            int pivot = nums[left];
            while (i<j)
            {
                while (i < right && nums[i] <= pivot) i++;
                while (nums[j] > pivot) j--;
                if (i<j)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }

            }

            (nums[left], nums[j]) = (nums[j], nums[left]);
            return j;
        }
    }
}
