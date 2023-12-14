using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode118Pascal__tri
    {
        public IList<IList<int>> Generate(int numRows)
        {
            //声明一个二维i数组
            IList<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                //子数组
                IList<int> sub = new List<int>();
                //添加1 除了 j等于第一位和最后一位
                for (int j = 0; j <= i; j++)
                {
                    //然后是 就添加1
                    if (j == 0 || j == i)
                    {
                        sub.Add(1);
                    }
                    else
                    {
                        //!不是 也就是需要相加的地方
                        //todo 访问前一列 并且获取j-1 和 j的位置先加
                        //以为如下
                        //todo  1 1
                        //todo 1 2 1 => 前一列为11 所有现在获取j = 1 那么 也就是 0 和 1的位置的值先加
                        IList<int> preRow = list[i - 1];
                        sub.Add(preRow[j - 1] + preRow[j]);
                    }
                }
                //最后添加到list pascals triangle
                list.Add(sub);
            }
            return list;
        }
    }
}
