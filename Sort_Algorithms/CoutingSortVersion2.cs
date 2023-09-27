using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class CoutingSortVersion2
    {
        public static void CountingSortStable(ProductUserForCountngSort[] nums)
        {
            // 找到最大的价格以确定计数数组的大小
            int maxPrice = 0;
            foreach (var item in nums)
            {
                maxPrice = Math.Max(item.Price, maxPrice);
            }

            // 创建计数数组
            int[] countArray = new int[maxPrice + 1];

            // 计算每个价格出现的次数
            foreach (var item in nums)
            {
                countArray[item.Price]++;
            }

            // 计算累积出现次数，将它们作为元素在结果数组中的索引
            for (int i = 1; i < countArray.Length; i++)
            {
                countArray[i] += countArray[i - 1];
            }

            // 临时数组用于存储排序后的结果
            ProductUserForCountngSort[] sortedArray = new ProductUserForCountngSort[nums.Length];

            // 从原始数组中按顺序取出元素并放入排序后的位置
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int price = nums[i].Price;
                int index = countArray[price] - 1;
                sortedArray[index] = nums[i];
                countArray[price]--;
            }

            // 将排序后的结果拷贝回原始数组
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = sortedArray[i];
            }
        }

    }
}
