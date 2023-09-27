using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    class CountingSortSolution3
    {
        public static void CountingSortSolution(ProductUserForCountngSort[] products)
        {
            //获得最大值
            int max = 0;
            foreach (var item in products)
            {
                max = Math.Max(item.Price, max);
            }

            //count array用来保存次数
            //它的大小是max + 1
            int[] countArray = new int[max+1];
            //进行计算次数
            foreach (var item in products)
            {
                countArray[item.Price]++;
                //等于 countArray[item.price](值)+1
            }

            //今次前缀和次数计算
            for (int i = 1; i < countArray.Length; i++)
            {
                //前缀和修改原来的countarray
                //每个前缀和 代表前面有几个小于的数比如
                //前缀和的确代表了在某个索引位置之前所有元素的和，因此可以将其视为“和前面的数先加这个数值”
                //       0 1 1 2
                //res=   0 1 2 4  
                //主要是计算具体位置
                countArray[i] += countArray[i - 1];
            }


            //创建一个res用来保存排号的数列
            ProductUserForCountngSort[] resList = new ProductUserForCountngSort[products.Length];

            for (int i = products.Length - 1; i >=0 ; i--)
            {
                int price = products[i].Price;

                int index = countArray[price] -1;
                resList[index] = products[i];
                countArray[price]--;
            }

            for (int i = 0; i < resList.Length; i++)
            {
                products[i] = resList[i];
            }
        }
    }
}
