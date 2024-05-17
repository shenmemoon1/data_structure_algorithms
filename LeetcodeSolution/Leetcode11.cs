using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode11
    {
        public static int MaxArea(int[] height)
        {
            int MxArea = 0;
            int i = 0, j = height.Length - 1;
            while (i < j)
            {
                int Area = (j - i) * Math.Min(height[i], height[j]);

                if (height[i] < height[j])
                {
                    MxArea = Math.Max(MxArea, Area);
                    i++;
                }
                else
                {
                    MxArea = Math.Max(MxArea, Area);
                    j--;
                }
            }
            return MxArea;
        }
    }
}
