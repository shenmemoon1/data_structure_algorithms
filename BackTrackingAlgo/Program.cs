using System;
using System.Collections.Generic;
using DivideAndConquer;

namespace BackTrackingAlgo
{
    class Program
    {
        //储存结构
        public static List<List<TreeNode>> res = new List<List<TreeNode>>();
        //储存路线
        public static List<TreeNode> path = new List<TreeNode>();
        static void Main(string[] args)
        {

            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(7);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);
            TreeNode n7 = new TreeNode(7);
            TreeNode n8 = new TreeNode(7);

            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n3.left = n6;
            n3.right = n7;
            n4.left = n8;

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
            Console.WriteLine("-------------------bianry path except 3--------------------");
            BianrySearchPath3.PreOrder(n1);
            foreach (List<TreeNode> item in BianrySearchPath3.res)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Console.Write($"[{item[i].value}]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------optimization bianry path except 3--------------------");
            List<TreeNode> choice = new List<TreeNode>() { n1.left, n1.right };
            OptimizationBinarybacktracking.backtrack(path, choice, res);
            foreach (List<TreeNode> item in res)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Console.Write($"[{item[i].value}]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------数字组合-----------------------------------------");
            int[] candidates = { 2, 3, 6, 7 };
            List<List<int>> res2 = CombinationSum.CombinationNum(candidates, 7);
            foreach (List<int> item in res2)
            {
                Console.Write('[');
                for (int i = 0; i < item.Count; i++)
                {
                    Console.Write(item[i]);
                }
                Console.Write(']');
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------permutation-------------------------------------------");
            int[] nums = new int[] { 1, 2, 3 };
            Permutations.PermutationCollect(nums);
            foreach (List<int> item in Permutations.PermutationCollect(nums))
            {
                Console.Write('[');
                for (int i = 0; i < item.Count; i++)
                {
                    Console.Write(item[i]);
                }
                Console.Write(']');
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------permutation 2------------------------------------------------------");
            int[] arr = { 1, 1, 2 };
            Leetcode47Permutate2.PermuteUnique(arr);
        }
    }
}
