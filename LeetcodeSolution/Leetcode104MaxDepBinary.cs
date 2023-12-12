using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode104MaxDepBinary
    {
        public class Solution
        {
            // 计算二叉树的最大深度
            public int MaxDepth(TreeNode root)
            {
                if (root == null) return 0; // 如果根节点为空，返回深度为 0
                List<int> depths = new List<int>(); // 用于存储所有路径深度的列表
                Callback(root, 1, depths); // 调用回调函数计算深度
                return depths.Max(); // 返回深度列表中的最大值
            }

            // 回调函数，用于遍历树并记录深度
            public void Callback(TreeNode node, int depth, List<int> depths)
            {
                if (node == null) return; // 如果节点为空，结束当前遍历

                if (node.left == null && node.right == null)
                {
                    depths.Add(depth); // 如果当前节点是叶子节点，将其深度添加到列表中
                    return;
                }
                Callback(node.left, depth + 1, depths); // 递归处理左子节点，深度加 1
                Callback(node.right, depth + 1, depths); // 递归处理右子节点，深度加 1
            }
        }

    }
}
