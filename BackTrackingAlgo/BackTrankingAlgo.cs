using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class BackTrankingAlgo
    {
        //QA1： 给定一个二叉树，搜索并记录所有值为7的节点，请返回节点列表。
        //Solution for QA1
        public static void PreOrdre(TreeNode root)
        {
            //记录7节点的数量
            List<TreeNode> res = new List<TreeNode>();
            //如果根节点为空 直接返回
            if (root == null)
            {
                return;
            }
            //确实root节点值是否为7 如果是就加入到res里面记录
            if (root.value == 7)
            {
                //记录解
                res.Add(root);
            }

            PreOrdre(root.left);
            PreOrdre(root.right);
        }
    }
}
