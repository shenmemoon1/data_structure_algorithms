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
            Dictionary<int, int> inorderMap = new Dictionary<int, int>();
            for (int i = 0; i < inOrder.Length; i++)
            {
                inorderMap.TryAdd(inOrder[i], i);
            }

            TreeNode root = Dfs(preOrder, inorderMap, 0, 0, inOrder.Length - 1);
            return root;
        }

        private static TreeNode Dfs(int[] preOrder, Dictionary<int, int> inorderMap, int i, int l, int r)
        {
            if (r-l <0)
            {
                return null;
            }
            //root node
            TreeNode root = new TreeNode(preOrder[i]);
            //get node index in inordermap
            int m = inorderMap[preOrder[i]];
            root.left =  Dfs(preOrder, inorderMap, i + 1, l, m - 1);
            root.right = Dfs(preOrder, inorderMap, i + 1 + m - l, m + 1, r);
            return root;
        }

    }
}
