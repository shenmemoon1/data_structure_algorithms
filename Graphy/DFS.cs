using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphy
{
    class DFS
    {
        public static List<Vertex> graphDfs(GraphHash graph, Vertex vertex)
        {
            List<Vertex> res = new List<Vertex>();
            HashSet<Vertex> visited = new HashSet<Vertex>();
            dfsSup(graph, res, visited, vertex);
            return res;

        }

        private static void dfsSup(GraphHash graph, List<Vertex> res, HashSet<Vertex> visited, Vertex startVert)
        {
            //从第一个节点开始
            res.Add(startVert);
            //后面用来判断是否存在
            visited.Add(startVert);

            //值是一个数组所以进行遍历
            //获取顶点的相邻顶点
            foreach (Vertex vert in graph.adjList[startVert])
            {
                if (visited.Contains(vert))
                {
                    continue;
                }

                //递归
                dfsSup(graph, res, visited, vert);
            }
        }
    }
}
