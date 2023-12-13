using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class _111LeetcodeMinBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            List<int> depths = new List<int>();
            Callback(root, 1, depths);
            return depths.Min();
        }

        public void Callback(TreeNode node, int dep, List<int> depths)
        {
            if (node.left == null && node.right == null)
            {
                depths.Add(dep);
                return;
            }

            if (node.left != null)
            {
                Callback(node.left, dep + 1, depths);
            }
            if (node.right != null)
            {
                Callback(node.right, dep + 1, depths);
            }
        }

    }
}
