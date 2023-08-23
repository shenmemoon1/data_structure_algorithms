using System;


namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(4);
            TreeNode t2 = new TreeNode(2);
            TreeNode t3 = new TreeNode(5);
            TreeNode t4 = new TreeNode(1);
            TreeNode t5 = new TreeNode(3);

            t1.left = t2;
            t1.right = t3;
            t2.left = t4;
            t2.right = t5;

        }
    }
}
