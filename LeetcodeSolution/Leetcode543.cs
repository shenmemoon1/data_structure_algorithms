using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode543
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;

            int maxLength = 0;

            CalculatePathLength(root, ref maxLength);

            return maxLength;
        }

        private int CalculatePathLength(TreeNode node, ref int maxLength)
        {
            if (node == null) return 0;

            int leftPathLength = CalculatePathLength(node.left, ref maxLength);
            int rightPathLength = CalculatePathLength(node.right, ref maxLength);

            // 更新最大长度
            maxLength = Math.Max(maxLength, leftPathLength + rightPathLength);

            // 返回以当前节点为根的子树的最大深度
            return 1 + Math.Max(leftPathLength, rightPathLength);
        }
    }
}
