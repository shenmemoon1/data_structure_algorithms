using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class _110BlanceBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            if (Math.Abs(Height(root.left) - Height(root.right)) > 1) return false;
            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        public int Height(TreeNode node)
        {
            if (node == null) return 0;
            return Math.Max(Height(node.left), Height(node.right)) + 1;
        }
    }
}
