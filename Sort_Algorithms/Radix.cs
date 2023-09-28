using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class Radix
    {
        /// <summary>
        /// 使用基数排序算法对整数数组进行排序。
        /// </summary>
        /// <param name="nums">要排序的整数数组。</param>
        public static void RadixSort(int[] nums)
        {
            //查找最大值
            int max = int.MinValue;
            foreach (var item in nums)
            {
                max = Math.Max(item, max);
            }

            // 外层循环根据位数进行迭代
            for (int exp = 1; exp < max; exp *= 10)
            {
                // 调用基数排序的一次迭代，根据当前位数排序
                CountingSortDigital(nums, exp);
            }
        }

        /// <summary>
        /// 使用计数排序算法对整数数组按指定位数进行排序。
        /// </summary>
        /// <param name="nums">要排序的整数数组。</param>
        /// <param name="exp">当前位数，用于提取每个元素的相应数字。</param>
        private static void CountingSortDigital(int[] nums, int exp)
        {
            int[] counter = new int[10];

            // 统计当前位数上各数字的出现次数
            foreach (var item in nums)
            {
                int d = GetDigit(item, exp);
                counter[d]++;
            }

            // 将计数数组转化为累积次数数组，确定每个数字的最终位置
            for (int i = 1; i < 10; i++)
            {
                counter[i] += counter[i - 1];
            }

            int[] res = new int[nums.Length];

            // 从原数组末尾开始遍历，根据当前位数将元素放置到正确的位置
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int d = GetDigit(nums[i], exp);
                int index = counter[d] - 1;
                res[index] = nums[i];
                counter[d]--;
            }

            // 将排序后的结果拷贝回原始数组
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = res[i];
            }
        }

        /// <summary>
        /// 从整数中提取指定位数的数字。
        /// </summary>
        /// <param name="item">要提取数字的整数。</param>
        /// <param name="exp">指定的位数，用于提取相应的数字。</param>
        /// <returns>提取的数字。</returns>
        private static int GetDigit(int item, int exp)
        {
            ///首先，我们将 item 除以 exp，这将把数字右移，使得要获取的位数变为个位数（如果 exp 是10的幂，就变为个位数；
            ///如果 exp 是100的幂，就变为十位数，依此类推）。这相当于将待排序数字 "移到" 指定的位数上，以便提取。
            ///然后，我们对10取模，以获取当前位数上的值。这是因为一个数字的每一位都是在10进制下的，所以对10取模可以得到该位的值。
            return (item / exp) % 10;
        }

    }
}
