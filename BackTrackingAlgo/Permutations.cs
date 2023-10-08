using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTrackingAlgo
{
    class Permutations
    {
        //input [1,2,3]
        //ouput: all possible permutations
        public static List<List<int>> PermutationCollect(int[] nums)
        {
            List<int> currentPermutation = new List<int>();
            List<List<int>> result = new List<List<int>>();
            bool[] used = new bool[nums.Length];

            void GeneratePermutation()
            {
                if (currentPermutation.Count == nums.Length)
                {
                    result.Add(currentPermutation);
                    return;
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (!used[i])
                    {
                        currentPermutation.Add(nums[i]);
                        used[i] = true;
                        GeneratePermutation();
                        used[i] = false;
                        currentPermutation.RemoveAt(currentPermutation.Count - 1);
                    }
                }
            }
            GeneratePermutation();
            return result;
        }
    }
}
