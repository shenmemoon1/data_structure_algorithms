using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode136
    {
        public int SingleNumber(int[] nums)
        {
            int findSingleOccurenceKey = FindSingleOcurrenceKey(nums);
            return findSingleOccurenceKey;
        }

        public int FindSingleOcurrenceKey(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int key in nums)
            {
                if (dic.ContainsKey(key))
                {
                    dic[key]++;
                }
                else
                {
                    dic[key] = 1;
                }
            }

            foreach (var kvp in dic)
            {
                if (kvp.Value == 1)
                {
                    return kvp.Key;
                }
            }

            return 0;
        }
    }
}
