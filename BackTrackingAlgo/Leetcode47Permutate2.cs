using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTrackingAlgo
{
    class Leetcode47Permutate2
    {
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<int> path = new List<int>();
            IList<IList<int>> res = new List<IList<int>>();
            Backtrack(path, nums, res, new bool[nums.Length]);
            return res;
        }

        private static void Backtrack(List<int> path, int[] nums, IList<IList<int>> res, bool[] selected)
        {
            if (path.Count == nums.Length)
            {
                res.Add(new List<int>(path));
                return;
            }

            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (selected[i] || hashSet.Contains(nums[i]))
                {
                    continue; // 跳过已选元素或重复元素
                }
                path.Add(nums[i]);
                selected[i] = true;
                hashSet.Add(nums[i]); // 将已使用的元素加入 hashSet
                Backtrack(path, nums, res, selected);
                path.RemoveAt(path.Count - 1);
                selected[i] = false;
            }
        }

    }
}
