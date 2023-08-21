using System;
using System.Collections.Generic;
using BinaryTree;
namespace BinaryTree
{

    class Program
    {
        public static TreeNode findTree(TreeNode root, int num)
        {
            TreeNode cur = root; //8
            while (cur != null)
            {
                if (cur.val > num)
                {
                    cur = cur.left;
                }
                else if(cur.val < num)
                {
                    cur = cur.right;
                }
                else
                {
                    break;
                }
            }
            return cur;
        }

        //插入节点
        public void insert(TreeNode root, int num)
        {
            TreeNode node = new TreeNode(num);

        }

        static void Main(string[] args)
        {
            TreeNode treeNode1 = new TreeNode(1);
            TreeNode treeNode2 = new TreeNode(2);
            TreeNode treeNode3 = new TreeNode(3);
            TreeNode treeNode4 = new TreeNode(4);
            TreeNode treeNode5 = new TreeNode(5);
            TreeNode treeNode6 = new TreeNode(6);
            TreeNode treeNode7 = new TreeNode(7);
            TreeNode treeNode8 = new TreeNode(8);
            TreeNode treeNode9 = new TreeNode(9);
            TreeNode treeNode10 = new TreeNode(10);

            treeNode8.left = treeNode4;
            treeNode4.left = treeNode2;
            treeNode4.right = treeNode6;
            treeNode2.left = treeNode1;
            treeNode2.right = treeNode3;
            treeNode6.left = treeNode5;
            treeNode6.right = treeNode7;
            treeNode8.right = treeNode9;
            treeNode9.right = treeNode10;

            TreeNode fnode = findTree(treeNode8, 7);
            Console.WriteLine(fnode.val);
        }
    }
}
