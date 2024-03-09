using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode704
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            Dictionary<int, int> dic = new Dictionary<int, int>(nums.Length);

            foreach (var (num, index) in nums.Select((value, i) => (value, i)))
            {
                dic[num] = index;
            }


            return FindTarget(dic, target);
        }

        public int FindTarget(Dictionary<int, int> dic, int target)
        {
            int left = 0;
            int right = dic.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                var element = dic.ElementAt(mid);

                if (element.Key == target)
                {
                    return element.Value;
                }
                else if (element.Key < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
