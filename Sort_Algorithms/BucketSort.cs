using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class BucketSort
    {
        public static void BucketSor(double[] nums)
        {
            //设置桶的数量为k
            int k = nums.Length / 2;
            //list桶
            List<List<double>> buckets = new();
            for (int i = 0; i < k; i++)
            {
                buckets.Add(new List<double>());
            }
            //遍历nums里面的值 让它成K 向下取整获取index
            foreach (double item in nums)
            {
                //获得index
                int index = (int)(item * k);
                //放入指定桶里面
                buckets[index].Add(item);
            }

            //对桶进行sort
            foreach (List<double> bucket in buckets)
            {
                bucket.Sort();
            }

            //对桶里面的值继续遍历
            foreach (List<double> bucket in buckets)
            {
                foreach (double item in bucket)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
