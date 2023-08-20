using System;
using BinaryTree;

namespace BinaryTree
{

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode1 = new TreeNode(33);
            TreeNode treeNode2 = new TreeNode(66);
            TreeNode treeNode3 = new TreeNode(89);
            TreeNode treeNode4 = new TreeNode(59);

            treeNode1.left = treeNode2;
            treeNode1.right = treeNode3;
            treeNode2.left = treeNode4;

            TreeNode p = new(0);
            treeNode1.left = p;
            p.left = treeNode2;


        }
    }
}
