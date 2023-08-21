using System;
using System.Collections.Generic;
using BinaryTree;

namespace BinaryTree
{

    class Program
    {
        public static List<int> list2 = new List<int>();
        public static List<int> list3 = new List<int>();
        public static List<int> list4 = new List<int>();
        //层序遍历 level-order traversal
        public static List<int> levelOrder(TreeNode root)
        {
            //初始化队列 加入根节点
            Queue<TreeNode> que = new();
            que.Enqueue(root);
            //初始化一个列表， 用于保存遍历序列
            List<int> list = new();
            while (que.Count != 0)
            {
                TreeNode node = que.Dequeue(); //出列
                list.Add(node.val); //保存节点值
                if (node.left != null)
                {
                    que.Enqueue(node.left); //左节点入列
                }
                if (node.right != null)
                {
                    que.Enqueue(node.right); //右节点入列
                }
            }

            return list;
        }
        //前序遍历
        public static void preOrder(TreeNode root)
        {
            if (root == null) return;

            //访问优先级 root->left->right
            list2.Add(root.val);
            //looping left
            preOrder(root.left);
            //looping right
            preOrder(root.right);
        }

        //中序遍历

        public static void inOrder(TreeNode? root)
        {
            if (root == null) return;
            inOrder(root.left);
            list3.Add(root.val);
            inOrder(root.right);
        }

        //post-order
        public static void postOrder(TreeNode? root)
        {
            if (root == null) return;
            postOrder(root.left);
            postOrder(root.right);
            list4.Add(root.val);
        }

        static void Main(string[] args)
        {
            TreeNode treeNode1 = new TreeNode(1);
            TreeNode treeNode2 = new TreeNode(2);
            TreeNode treeNode3 = new TreeNode(3);
            TreeNode treeNode4 = new TreeNode(4);
            TreeNode treeNode5 = new TreeNode(5);

            treeNode1.left = treeNode2;
            treeNode1.right = treeNode3;
            treeNode2.left = treeNode4;
            treeNode2.right = treeNode5;

            //print pre order
            preOrder(treeNode1);
            foreach (int val in list2)
            {
                Console.Write($"{val}-");
            }

            Console.WriteLine();

            //print in-order
            inOrder(treeNode1);
            foreach (int val in list3)
            {
                Console.Write($"{val}-");
            }

            Console.WriteLine();

            //print post-order
            postOrder(treeNode1);
            foreach (int val in list4)
            {
                Console.Write($"{val}-");
            }

        }
    }
}
