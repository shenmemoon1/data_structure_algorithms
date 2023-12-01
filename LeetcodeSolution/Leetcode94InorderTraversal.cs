using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class Leetcode94InorderTraversal
    {
        //声明一个数组用于返回
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();

            dfs(root, res);
            //return 最后的遍历结果
            return res;
        }

        //一个dfs递归
        public static void dfs(TreeNode root, IList<int> list)
        {
            //如果根节点为空的情况
            //结束条件
            if (root == null) return;

            //中序遍历 为左节点-根节点-右节点 结构
            //寻找左节点最后一个左节点
            //root = [1, null, 2, 3]
            //例子中1 为根节点 进入左节点
            dfs(root.left, list);
            //获取的最最左的节点
            //发现左侧为空 那么直接触发条件
            //把根节点1 加入
            list.Add(root.val);
            //进入右节点
            dfs(root.right, list);
            //过程如下：
            //根 = 2
            //进入左侧子节点
            //根 = 3
            //左侧为空
            //加入到数列 【1，3】
            //进入右侧
            //为空 返回 【1，3】
            //3 的子结构都结束返回到2的
            //接入2 【1，3，2】
            //获取右侧 发现为空 
            //结束

        }

        
    }
}
