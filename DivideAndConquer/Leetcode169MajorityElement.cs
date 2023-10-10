using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class Leetcode169MajorityElement
    {
        public static int MajorityElement(int[] nums)
        {
            return CounterElement(0, nums.Length -1, nums);
        }

        private static int CounterElement(int left, int right, int[] nums)
        {

            if (left == right) return nums[left];
            int mid = (left + right) / 2; //1 , 0

            int majorityLeft = CounterElement(left, mid, nums); //[0,1]=>3,2 =>3
            int majorityRight = CounterElement(mid + 1, right, nums);//[2] =>3 => 2

            if (majorityLeft == majorityRight) return majorityLeft;

            int left_count = CountNum(majorityLeft, left, mid, nums);
            int right_count = CountNum(majorityRight, left, mid, nums);

            if (left_count > (nums.Length) / 2) return majorityLeft;
            else return majorityRight;

        }

        private static int CountNum(int Mleft, int left, int right, int[] nums)
        {
            int count = 0;
            for (int i = 0; i <= right; i++)
            {
                if (nums[i] == Mleft)
                {
                    count++;
                }
            }

            return count;
        }


        public static int MajorityElement2(int[] nums)
        {
            int candidate = nums[0];
            int count = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                    count = 1;
                }
                else if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }
    }
}
