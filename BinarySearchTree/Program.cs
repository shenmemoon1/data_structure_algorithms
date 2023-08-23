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
        public static void insert(TreeNode root, int num)
        {
            // 若树为空，直接提前返回
            if (root == null)
                return;

            TreeNode node = new TreeNode(num);
            TreeNode cur = root;
            TreeNode pre;
            while (cur!=null)
            {
                if (cur.val > num)
                {
                    pre = cur;
                    cur = cur.left;
                    if (cur == null)
                    {
                        pre.left = node;
                    }
                }
                else
                {
                    pre = cur;
                    cur = cur.right;
                    if (cur == null)
                    {
                        pre.right = node;
                    }
                }
            }
        }

        

        //删除节点
        public static void remove(TreeNode root, int num)
        {
            //节点为空 返回
            if (root == null)
            {
                return;
            }

            //设置prev,cur节点
            TreeNode cur = root, prev = null;
            while (cur != null)
            {
                if (cur.val == num)
                    break;
                prev = cur;
                if (cur.val > num)
                    cur = cur.left;
                else
                    cur = cur.right;
            }


            //子节点 = 0 or 1
            if (cur.left == null || cur.right == null)
            {
                TreeNode child = cur.left != null ? cur.left : cur.right;
                if (cur != root)
                    if (prev.left == cur)
                        prev.left = child;
                    else
                        prev.right = child;
                else
                    root = child;
            }

            //子节点 = 2;
            else
            {
                TreeNode? tep = cur.right;
                while (tep.left != null)
                {
                    tep = tep.left;
                }

                remove(root, tep.val);
                cur.val = tep.val;
            }             
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

            remove(treeNode8, 2);

            
        }
    }
}
