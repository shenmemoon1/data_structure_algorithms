using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode70ClimbingStair
    {
        public static int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            Dictionary<int, int> dic = new Dictionary<int,int>();
            dic.Add(1, 1);
            dic.Add(2, 2);

            for (int i = 3; i <= n; i++)
            {
                if (!dic.ContainsKey(n))
                {
                    dic.Add(i, dic[i - 1] + dic[i - 2]);
                }
            }
            return dic[dic.Count];
        }
    }
}
