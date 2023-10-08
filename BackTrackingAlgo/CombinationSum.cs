using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTrackingAlgo
{
    class CombinationSum
    {
        /*
         * 问题：组合总和给定一个正整数数组 candidates 和一个目标整数 target，找出数组中所有可以使数字和等于 target 的唯一组合。
         * 数组中的每个数字可以重复使用。
         * 例子： 
         * [2,3,6,7]
         * ouput:
         * [2,2,3]
         * [7]
         */

        public static List<List<int>> CombinationNum(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> curCombination = new List<int>();

            void BackTrack(int remainingTarget, int startIndex)
            {
                if (remainingTarget == 0)
                {
                    result.Add(new List<int>(curCombination));
                }

                if (remainingTarget < 0)
                {
                    return;
                }

                for (int i = startIndex; i < candidates.Length; i++)
                {
                    curCombination.Add(candidates[i]);
                    BackTrack(remainingTarget - candidates[i], i);
                    curCombination.RemoveAt(curCombination.Count - 1); // 回溯，移除最后一个元素
                }
            }

            BackTrack(target, 0);
            return result;
        }

    }
}
