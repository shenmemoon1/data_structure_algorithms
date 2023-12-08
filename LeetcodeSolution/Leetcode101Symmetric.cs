using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode101Symmetric
    {
        public bool IsSymmetric(TreeNode root)
        {
            // 如果根节点为空，直接返回true，因为空树被认为是对称的
            if (root == null) return true;

            // 调用辅助方法进行递归判断左右子树是否对称
            return Callback(root.left, root.right);
        }

        public bool Callback(TreeNode node1, TreeNode node2)
        {
            // 如果两个节点都为空，说明对称
            if (node1 == null && node2 == null) return true;

            // 如果一个节点为空或者节点的值不相等，则不对称
            if (node1 == null || node2 == null || node1.val != node2.val)
            {
                return false;
            }

            // 递归比较节点1的左子节点与节点2的右子节点，节点1的右子节点与节点2的左子节点
            return Callback(node1.left, node2.right) && Callback(node1.right, node2.left);
        }
        /*为什么需要使用递归：

        二叉树对称性的判断需要比较根节点的左右子树是否对称，以及左子树的左子树和右子树的右子树、
        左子树的右子树和右子树的左子树是否对称。递归很适合解决这种对称性质问题，因为它能够很自然地比较树的结构。
        整个题的思路：

        首先，检查根节点是否为空，若为空，则认为它是对称的。
        然后，调用一个递归的辅助函数 Callback，比较左右子树是否对称。
        在 Callback 函数中，先检查两个节点是否同时为空，若是则认为它们对称；如果其中一个节点为空，或者节点的值不相等，则不对称。
        接着，递归地比较 node1 的左子节点与 node2 的右子节点，以及 node1 的右子节点与 node2 的左子节点，以确保整个树的对称性。
        整个过程：

        首先，检查根节点是否为空，若为空则返回 true 表示对称。
        然后调用 Callback 辅助函数进行递归判断。
        在 Callback 中，先检查当前节点是否对称，若不对
         */
    }
}
