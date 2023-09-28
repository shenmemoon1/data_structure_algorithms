using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class Radix
    {
        public static void RadixSort(int[] nums)
        {
            int max = int.MinValue;
            foreach (var item in nums)
            {
                max = Math.Max(item, max);
            }

            for (int exp = 1; exp < max; exp *= 10)
            {
                coutingSortDigital(nums, exp);
            }
        }

        private static void coutingSortDigital(int[] nums, int exp)
        {
            int[] counter = new int[10];
            foreach (var item in nums)
            {
                int d = digital(item, exp);
                counter[d]++;
            }

            for (int i = 1; i < 10; i++)
            {
                counter[i] += counter[i - 1];
            }

            int[] res = new int[nums.Length];

            for (int i = nums.Length -1; i >= 0; i--)
            {
                int d = digital(nums[i], exp);
                int index = counter[d] - 1;
                res[index] = nums[i];
                counter[d]--;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = res[i];
            }

        }

        private static int digital(int item, int exp)
        {
            return (item / exp) % 10;
        }
    }
}
