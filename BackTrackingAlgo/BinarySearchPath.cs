using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DivideAndConquer;

namespace BackTrackingAlgo
{
    class BinarySearchPath
    {
        //在二叉树中搜索所有值为7的节点，请返回根节点到这些节点的路径。

        //记录
        public static List<TreeNode> path = new List<TreeNode>();
        public static List<List<TreeNode>> res = new List<List<TreeNode>>();
        public static void PreOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            path.Add(root);
            if (root.value == 7)
            {
                res.Add(new List<TreeNode>(path));
            }

            PreOrder(root.left);
            PreOrder(root.right);

            path.RemoveAt(path.Count -1);
        }
    }
}
