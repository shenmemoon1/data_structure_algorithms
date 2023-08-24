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
            TreeNode? grandChild = child.right;
            //以child作为原点 将node向右旋转
            child.right = node;
            node.left = grandChild;
            //更新节点高度
            updateHeight(node);
            updateHeight(child);

            return child;
        }

        /* 左旋操作 */
        static TreeNode? leftRotate(TreeNode? node)
        {
            TreeNode? child = node.right;
            TreeNode? grandChild = child.left;
            // 以 child 为原点，将 node 向左旋转
            child.left = node;
            node.right = grandChild;
            // 更新节点高度
            updateHeight(node);
            updateHeight(child);
            // 返回旋转后子树的根节点
            return child;
        }


        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(4);
            TreeNode t2 = new TreeNode(2);
            TreeNode t3 = new TreeNode(5);
            TreeNode t4 = new TreeNode(1);
            TreeNode t5 = new TreeNode(3);
            TreeNode t6 = new TreeNode(6);
            TreeNode t7 = new TreeNode(8);

            t1.left = t2;
            t1.right = t3;
            t2.left = t4;
            t2.right = t5;
            t3.right = t6;
            t6.right = t7;

            leftRotate(t3);

            //解释
            /*
             * 在这里设置了child 和 grandchil来保存子孙节点
             首先 5-》 6-》8 右侧大于左部
            进行左旋转
                    6
                    |
                5 <- -> 8
            6作为根
            5变它的左节点
            8保持
            但是还需要知道6之前是否有左节点 如果有就放在5 的右侧 没有就返回
            所有变成 5
                    |
            null <- -> null
             */

        }
    }
}
