using System;
using System.Collections.Generic;
using DivideAndConquer;

namespace BackTrackingAlgo
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(7);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);
            TreeNode n7 = new TreeNode(7);

            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n3.left = n6;
            n3.right = n7;

            BackTranking.PreOrdre(n1);
            foreach (TreeNode item in BackTranking.res)
            {
                Console.WriteLine($"{item.value}-{item.GetHashCode()}");
            }
            Console.WriteLine("-------------------bianry path--------------------");
            BinarySearchPath.PreOrder(n1);
            foreach (List<TreeNode> item in BinarySearchPath.res)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Console.Write($"[{item[i].value}]");
                }
                Console.WriteLine();
            }
        }
    }
}
