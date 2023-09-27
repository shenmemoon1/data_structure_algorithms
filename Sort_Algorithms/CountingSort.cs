using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class CountingSort
    {
        //version 1
        public static void CountSort(int[] nums)
        {
            int size = 0;
            //设置一个counter数组用来记录次数
            foreach (int item in nums)
            {
                size = Math.Max(size, item);
            }
            int[] counter = new int[size +1];

            //次数计算
            foreach (int item in nums)
            {
                counter[item]++;
            }

            //打印
            int num = 0;
            for (int i = 0; i < size + 1; i++)
            {
                for (int j = 0; j < counter[i]; j++)
                {
                    nums[num] = i;
                    num++;
                }
            }

        }
    }
}
