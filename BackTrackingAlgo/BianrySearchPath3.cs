using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DivideAndConquer;

namespace BackTrackingAlgo
{
    class BianrySearchPath3
    {
        //在二叉树中搜索所有值为7的节点，请返回根节点到这些节点的路径，并要求路径中不包含值为3的节点。

        //储存结构
        public static List<List<TreeNode>> res = new List<List<TreeNode>>();
        //储存路线
        public static List<TreeNode> path = new List<TreeNode>();

        public static void PreOrder(TreeNode root)
        {
            //根为空
            //剪枝
            //遇到3 直接返回
            if (root == null || root.value == 3)
            {
                return;
            }

            //添加路线
            path.Add(root);
            if (root.value == 7)
            {
                //添加整个路线
                res.Add(new List<TreeNode>(path));
            }

            PreOrder(root.left);
            PreOrder(root.right);

            path.RemoveAt(path.Count - 1);

        }

    }
}
