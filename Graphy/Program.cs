using System;
using System.Collections.Generic;

namespace Graphy
{
    class Program
    {
        //BFS
        static List<Vertex> graphBfs(GraphHash graph, Vertex startVet)
        {
            //顶点遍历序列
            List<Vertex> res = new List<Vertex>();
            //哈希表 用于记录顶点是否被访问
            HashSet<Vertex> visited = new HashSet<Vertex>() { startVet };
            //队列实现BFS
            Queue<Vertex> que = new Queue<Vertex>();
            que.Enqueue(startVet);
            //从初始顶点开始 循环走完去全部顶点
            while (que.Count > 0)
            {
                Vertex vet = que.Dequeue();
                res.Add(vet);
                foreach (Vertex adjVet in graph.adjList[vet])
                {
                    if (visited.Contains(adjVet))
                    {
                        continue;
                    }
                    que.Enqueue(adjVet);
                    visited.Add(adjVet);
                }
            }

            //返回顶点遍历序列
            return res;

        }


        //DFS


        static void Main(string[] args)
        {
            //adjacency matrix
            int[] vertices = { 0, 1, 2, 3 ,5,6};
            int[][] edges = {
                new int[] { 0, 1 },
                new int[] { 0, 3 },
                new int[] { 1, 2 },
                new int[] { 2, 5 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
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
                new Vertex[] { vertx[0], vertx[1]},
                new Vertex[] { vertx[0], vertx[3]},
                new Vertex[] { vertx[1], vertx[2] },
                new Vertex[] { vertx[2], vertx[3] },
                //new Vertex[] { vertx[3], vertx[0] }
            };

            GraphHash graphHash = new GraphHash(edge);

            //遍历每个顶点并打印
            foreach (KeyValuePair<Vertex, List<Vertex>> entry in graphHash.adjList)
            {
                int key = entry.Key.value;
                List<Vertex> value = entry.Value;

                Console.Write(key.ToString() + "-->");
                foreach (Vertex item in value)
                {
                    Console.Write(item.value.ToString() + '-');
                }
                Console.WriteLine();
            }

            //BFS
            // 假设你有一个起始顶点 startVertex
            Vertex startVertex = vertx[0]; // 使用 vertx 数组中的一个顶点作为起始顶点

            List<Vertex> traversalSequence = graphBfs(graphHash, startVertex);

            Console.WriteLine("BFS 遍历顺序：");
            foreach (Vertex vertex in traversalSequence)
            {
                Console.WriteLine(vertex.value);
            }

        }
    }
}
