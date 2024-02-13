using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode543
    {
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            List<List<int>> list = new List<List<int>>();
            List<int> selected = new List<int>();

            FindLen(root, list, selected);

            int maxLength = 0;

            foreach (List<int> innerList in list)
            {
                if (innerList.Count > maxLength)
                {
                    maxLength = innerList.Count;
                }
            }

            return maxLength;
        }

        public static void FindLen(TreeNode root, List<List<int>> res, List<int> select)
        {
            if (root.left == null && root.right == null)
            {
                res.Add(new List<int>(select));
                return;
            }

            select.Add(root.val);
            FindLen(root.left, res, select);
            FindLen(root.right, res, select);
        }
    }
}
