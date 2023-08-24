using System;


namespace AVLTree
{
    class Program
    {
        public static int height(TreeNode? node)
        {
            //空节点高度为 -1 叶子节点为0
            return node == null ? -1 : 0;
        }

        //更新节点高度
        public static void updateHeight(TreeNode? node)
        {
            //节点高度等于最高子树高度
            node.height = Math.Max(height(node.left), height(node.right)) + 1;
        }

        //节点平衡因子
        //设平衡因子为 f 
        //则一棵 AVL 树的任意节点的平衡因子皆满足  -1 <= f <= 1
        public static int balanceFactor(TreeNode? node)
        {
            //空节点平衡因子 0
            if (node == null) return 0;
            //节点平衡因子 = 左子树高度 - 右子树高度
            return height(node.left) - height(node.right);
        }

        //右旋操作
        public static TreeNode? rightRotate(TreeNode? node)
        {
            TreeNode? child = node.left;
            TreeNode? grandChild = child?.right;
            //以child作为原点 将node向右旋转
            child.right = node;
            node.left = grandChild;
            //更新节点高度
            updateHeight(node);
            updateHeight(child);
            return child;
        }

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
