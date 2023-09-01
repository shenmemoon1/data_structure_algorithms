using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphy
{
    class Graph
    {
        //顶点列表
        public List<int> vert;
        //邻接矩阵
        public List<List<int>> adjaMatrix;
        public Graph(int[] vertics, int[][] edges)
        {
            this.vert = new List<int>();
            this.adjaMatrix = new List<List<int>>();

            //添加节点到顶点列表
            foreach (int i in vertics)
            {
                addVetex(i);
            }
            // 请注意，edges 元素代表顶点索引，即对应 vertices 元素索引
            foreach (int[] e in edges)
            {
                addEdge(e[0], e[1]);
            }

        }

        private void addEdge(int i, int j)
        {
            if (i<0 || j<0 || i > size() || j> size() || i ==j)
            {
                throw new IndexOutOfRangeException();
            }
            adjaMatrix[i][j] = 1;
            adjaMatrix[j][i] = 1;
        }

        public int size()
        {
            return this.vert.Count;
        }

        //添加顶点
        public void addVetex(int val)
        {
            //vertex 的长度
            int n = size();
            //添加到顶点
            vert.Add(val);

            //创建一个新的row
            List<int> newRow = new List<int>();
            for (int i = 0; i < n; i++)
            {
                newRow.Add(0);
            }

            adjaMatrix.Add(newRow);

            // 在邻接矩阵中添加一列
            foreach (List<int> row in adjaMatrix)
            {
                row.Add(0);
            }
        }

        public void removeVertex(int index)
        {
            if (index >= size())
                throw new IndexOutOfRangeException();
            //再列表里面移除顶点
            vert.RemoveAt(index);

            //移除列 从admatrix
            foreach (List<int> vs in adjaMatrix)
            {
                vs.RemoveAt(index);
            }
            //然后移除行
            adjaMatrix.RemoveAt(index);
        }
        // 参数 i, j 对应 vertices 元素索引
        public void removeEdges(int i , int j)
        {
            // 索引越界与相等处理
            if (i < 0 || j < 0 || i >= size() || j >= size() || i == j)
                throw new IndexOutOfRangeException();
            adjaMatrix[i][j] = 0;
            adjaMatrix[j][i] = 0;

        }
    }
}
