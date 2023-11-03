using System;

namespace Danamic_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //这个是使用回溯
            Console.WriteLine(DPClimbStairs.ClimbStairBacktrack(6));
            //暴力递推
            Console.WriteLine(DPclimbStair_dfs.ClimbStairDFS(6));
            //使用DP 记忆化
            Console.WriteLine(DPClimbStair_dfs_memory.ClimbStairDfs_Mem(6));
            //dp
            Console.WriteLine("----------------------------------------");
            int[] cost = {0,1,10,1,6,1};
            Console.WriteLine(DPClimbStair_min.MinCost_Stair(cost)) ;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(ConstrainDpClimb.ClimbingStairsConstraintDP(3));
            Console.WriteLine(FibonacciNumber.FibonacciDP(9));
            Console.WriteLine(FibonacciNumber.FibonacciIterative(9));
            Console.WriteLine(FibonacciNumber.FibonacciRecursive(9));

            Console.WriteLine("------------------------------------------");
        }
    }
}
