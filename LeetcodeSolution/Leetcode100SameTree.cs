using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode100SameTree
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            //如果都为空 直接为true
            if (p == null && q == null)
            {
                return true;
            }
            //如果一个为空或者他们值不相等 weifalse
            if (p == null || q == null || p.val != q.val)
            {
                return false;
            }
            //进入循环 遍历
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
