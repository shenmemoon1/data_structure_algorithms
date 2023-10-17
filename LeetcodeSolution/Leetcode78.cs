using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode78
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            //状态
            IList<int> path = new List<int>();
            //结果
            IList<IList<int>> result = new List<IList<int>>();
            FindSet(path, 0, nums, result);
            return result;
        }

        private static IList<IList<int>> FindSet(IList<int> path, int start, int[] nums, IList<IList<int>> res)
        {
            //[] 添加空
            res.Add(new List<int>(path));
            for (int i = start; i < nums.Length; i++)
            {
                path.Add(nums[i]);
                FindSet(path, i + 1, nums, res);
                path.RemoveAt(path.Count - 1);
            }
            return res;
        }
    }
}
