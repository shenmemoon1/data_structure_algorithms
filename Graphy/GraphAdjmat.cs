using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphy
{
    //基于邻接矩阵实现无向图类
    class GraphAdjmat
    {
        List<int> vertices; //顶点列表 元素代表 顶点值 索引代表顶点索引
        List<List<int>> adjMat; //临接矩阵， 行列索引对于顶点索引

        public GraphAdjmat(int[] vertices, int[][] edges)
        {
            this.vertices = new List<int>();
            this.adjMat = new List<List<int>>();
            //添加顶点
            foreach (int val in vertices)
            {
                addVertex(val);
            }

            //添加边
            foreach (int[] e in edges)
            {
                addEdge(e[0], e[1]);
            }
        }

        //获取顶点数量
        public int size()
        {
            return this.vertices.Count;
        }

        //添加顶点
        public void addVertex(int val)
        {
            int n = size();
            //向顶点添加新的顶点值
            vertices.Add(val);
            //添加一行在邻接矩阵
            List<int> newRow = new List<int>();
            for (int j = 0; j < n; j++)
            {
                newRow.Add(0);
            }

            adjMat.Add(newRow);
            //在邻接矩阵添加一列
            foreach (List<int> row in adjMat)
            {
                row.Add(0);
            }
        }

        /* 添加边 */
        // 参数 i, j 对应 vertices 元素索引
        public void addEdge(int i, int j)
        {
            // 索引越界与相等处理
            if (i < 0 || j < 0 || i >= size() || j >= size() || i == j)
                throw new IndexOutOfRangeException();
            // 在无向图中，邻接矩阵沿主对角线对称，即满足 (i, j) == (j, i)
            adjMat[i][j] = 1;
            adjMat[j][i] = 1;
        }

    }
}
