using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    /*
     * 「插入排序 insertion sort」是一种简单的排序算法，它的工作原理与手动整理一副牌的过程非常相似。
        具体来说，我们在未排序区间选择一个基准元素，将该元素与其左侧已排序区间的元素逐一比较大小，并将该元素插入到正确的位置。
     */
    class Insertion_Sort
    {
        //set a base value
        public void insertionSort(int[] nums)
        {
            //数组长度
            int size = nums.Length;
            for (int i = 1; i < size; i++)
            {
                //设数组第一个值为bas 已排序值
                //可以使用很多方法实现 这个只是一个例子
                //为了判断i之前的值
                /*for (int j = 0; j < i; j++)
                {
                    //i和前面所有值对比
                    if (nums[i] < nums[j])
                    {
                        (nums[i], nums[j]) = (nums[j], nums[i]);
                    }
                }*/

                //优化版
                //减少频繁交换
                int current = nums[i], j = i -1;
                while (j>=0 && nums[i]> current)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                nums[j + 1] = current;
                
            }
        }
    }
}
