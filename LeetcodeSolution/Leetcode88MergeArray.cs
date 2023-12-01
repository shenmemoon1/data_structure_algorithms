using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode88MergeArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //获取下标
            int i = m - 1, j = n - 1, k = m + n - 1;

            //只要j里面没有值了
            while (j >= 0)
            {
                //如果i没有值的情况
                if (i<0)
                {
                    while (j>=0)
                    {
                        nums1[k--] = nums2[j--];
                    }
                }

                //比较两个数组的最后一个值
                if(nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

        }
    }
}
