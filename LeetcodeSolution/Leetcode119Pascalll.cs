using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode119Pascalll
    {
        //给出一个rowindex 返回rowindex那一行的值
        public static IList<int> GetRow(int rowIndex)
        {
            //create a list to store each row
            IList<IList<int>> triangle = new List<IList<int>>();
            for (int i = 0; i <= rowIndex; i++)
            {
                //each row element
                List<int> sub = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        sub.Add(1);
                    }
                    else
                    {
                        IList<int> preRow = triangle[i - 1];
                        sub.Add(preRow[j - 1] + preRow[j]);
                    }
                }

                triangle.Add(sub);
            }

            return triangle[rowIndex];
        }
    }
}
