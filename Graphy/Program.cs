using System;
using System.Collections.Generic;

namespace Graphy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vertices = { 0, 1, 2, 3 };
            int[][] edges = {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 2 },
                new int[] { 2, 3 }
            };

            Graph graph = new Graph(vertices, edges);

            foreach (List<int> item in graph.adjaMatrix)
            {
                foreach (int i in item)
                {
                    Console.Write(i.ToString()+ ',');
                }
                Console.WriteLine();
            }
        }
    }
}
