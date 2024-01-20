using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class leetcode144
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();
            IList<int> path = new List<int>();
            PreOrder(root, path);
            return path;

        }

        public void PreOrder(TreeNode root, IList<int> list)
        {
            if (root == null) return;
            // root - left - right
            list.Add(root.val);
            PreOrder(root.left, list);
            PreOrder(root.right, list);
        }
    }
}
