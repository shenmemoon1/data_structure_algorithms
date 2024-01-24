using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class leetcode169_solution2
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 0);
                }
            }
            return FindMaxValue(dic);
        }
        static int FindMaxValue(Dictionary<int, int> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                //if dictionary is empty
                throw new InvalidOperationException("dictionary empty");
            }

            // get max key and value
            int maxKey = int.MinValue;
            int maxValue = int.MinValue;

            // loop all entry and return max key
            foreach (var entry in dictionary)
            {
                if (entry.Value > maxValue)
                {
                    maxKey = entry.Key;
                    maxValue = entry.Value;
                }
            }

            return maxKey;
        }
    }
}
