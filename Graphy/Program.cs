using System;
using System.Collections.Generic;

namespace Graphy
{
    class Program
    {
        static void Main(string[] args)
        {
            //adjacency matrix
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

            //List of adjacency
            // 创建一些顶点和边的数组
            Vertex[] vertx = new Vertex[]
            {
                new Vertex(1),
                new Vertex(2),
                new Vertex(3),
                new Vertex(4)
            };

            Vertex[][] edge = new Vertex[][]
            {
                new Vertex[] { vertx[0], vertx[1] },
                new Vertex[] { vertx[1], vertx[2] },
                new Vertex[] { vertx[2], vertx[3] },
                //new Vertex[] { vertx[3], vertx[0] }
            };

            GraphHash graphHash = new GraphHash(edge);
        }
    }
}
