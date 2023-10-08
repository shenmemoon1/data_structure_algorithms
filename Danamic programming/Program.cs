using System;

namespace Danamic_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //这个是使用回溯
            Console.WriteLine(DPClimbStairs.ClimbStairBacktrack(6));
            //DP
            Console.WriteLine(DPclimbStair_dfs.ClimbStairDFS(6));
        }
    }
}
