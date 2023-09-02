using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphy
{
    class GraphHash
    {
        //使用哈希形式key-value pair来储存值
        public Dictionary<Vertex, List<Vertex>> adjList;
        public GraphHash(Vertex[][] edges)
        {
            //初始化
            adjList = new Dictionary<Vertex, List<Vertex>>();
            //添加顶点和边 key==顶点 value== edges
            foreach (Vertex[] edge in edges)
            {
                addVertx(edge[0]);
                addVertx(edge[1]);
                addEdge(edge[0], edge[1]);
            }
        }

        //添加边
        private void addEdge(Vertex vertex1, Vertex vertex2)
        {
            if (vertex1 == vertex2 || !adjList.ContainsKey(vertex1) || !adjList.ContainsKey(vertex2))
            {
                throw new InvalidOperationException();
            }

            adjList[vertex1].Add(vertex2);
            adjList[vertex2].Add(vertex1);

        }

        private void removeEdge(Vertex v1, Vertex v2)
        {
            if (v1 == v2 || !adjList.ContainsKey(v1) || !adjList.ContainsKey(v1))
            {
                throw new InvalidOperationException();
            }

            adjList[v1].Remove(v1);
            adjList[v2].Remove(v2);
        }

        //添加操作
        private void addVertx(Vertex edge)
        {
            if (adjList.ContainsKey(edge))
            {
                return;
            }

            adjList.Add(edge, new List<Vertex>());

        }

        //去除顶点
        private void removeVertex(Vertex vertex)
        {
            if (!adjList.ContainsKey(vertex))
            {
                return;
            }

            adjList.Remove(vertex);

            //遍历所有的链表 移除移除顶点边
            foreach (List<Vertex> v in adjList.Values)
            {
                v.Remove(vertex);
            }
        }
    }
}
