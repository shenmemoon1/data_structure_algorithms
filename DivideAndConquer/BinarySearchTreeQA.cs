using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class BinarySearchTreeQA
    {
        /*
         * 给定一个二叉树的前序遍历 preorder 和中序遍历 inorder ，请从中构建二叉树，返回二叉树的根节点。
         */

        public static TreeNode BuildTree(int[] preOrder, int[] inOrder)
        {
            // 创建一个字典，用于存储中序遍历数组中的元素及其索引
            Dictionary<int, int> inorderMap = new Dictionary<int, int>();
            for (int i = 0; i < inOrder.Length; i++)
            {
                inorderMap.TryAdd(inOrder[i], i);
            }

            // 调用深度优先搜索方法开始构建二叉树，从整个树的根节点开始
            TreeNode root = Dfs(preOrder, inorderMap, 0, 0, inOrder.Length - 1);
            return root;
        }

        // 深度优先搜索方法，用于构建二叉树
        // 参数 i 表示当前根节点在前序遍历数组中的索引
        // 参数 l 表示当前子树在中序遍历数组中的起始索引
        // 参数 r 表示当前子树在中序遍历数组中的结束索引
        private static TreeNode Dfs(int[] preOrder, Dictionary<int, int> inorderMap, int i, int l, int r)
        {
            // 如果起始索引大于结束索引，表示当前子树为空，返回 null
            if (r - l < 0)
            {
                return null;
            }

            // 创建当前根节点
            TreeNode root = new TreeNode(preOrder[i]);

            // 获取当前根节点在中序遍历数组中的索引
            int m = inorderMap[preOrder[i]];

            // 递归构建左子树，左子树在前序遍历数组中的根节点索引为 i + 1，
            // 中序遍历数组中的起始索引为 l，结束索引为 m - 1
            root.left = Dfs(preOrder, inorderMap, i + 1, l, m - 1);

            // 递归构建右子树，右子树在前序遍历数组中的根节点索引为 i + 1 + m - l，
            // 中序遍历数组中的起始索引为 m + 1，结束索引为 r
            root.right = Dfs(preOrder, inorderMap, i + 1 + m - l, m + 1, r);

            // 返回当前根节点
            return root;
        }

    }
}
