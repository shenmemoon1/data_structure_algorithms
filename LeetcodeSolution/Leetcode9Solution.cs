using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode9Solution
    {
        public static bool IsPalindrome(int x)
        {
            //变成string （类似数组可以进行操作）
            string xStr = x.ToString();
            //左边游标
            int left = 0;
            //右边游标
            int right = 0;

            //当都循环结束 代表没有false 返回true
            while (left > right)
            {
                //左游标和右侧进行比较
                if (xStr[left] != xStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
