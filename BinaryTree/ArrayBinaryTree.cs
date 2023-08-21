using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class ArrayBinaryTree
    {

        private List<int?> tree;
        public ArrayBinaryTree(List<int?> arr)
        {
            tree = new List<int?>(arr);
        }

        //节点数量
        public int size()
        {
            return tree.Count;
        }

        //获取索引 i 节点的值
        public int? val(int i)
        {
            if (i < 0 || i >= size())
            {
                return null;
            }
            return tree[i];
        }


        //索引左节点

        public int left(int i)
        {
            return 2 * i + 1;
        }
        
        //索引右节点

        public int right(int i)
        {
            return 2 * i + 2;
        }

        /* 获取索引为 i 节点的父节点的索引 */
        public int parent(int i)
        {
            return (i - 1) / 2;
        }

        //层序遍历
        public List<int> levelOrder()
        {
            List<int> list = new List<int>();
            //直接遍历数组
            for (int i = 0; i < size(); i++)
            {
                if (val(i).HasValue)
                    list.Add(val(i).Value);
            }

            return list;
        }

        /* 深度优先遍历 */
        private void dfs(int i, string order, List<int> res)
        {
            // 若为空位，则返回
            if (!val(i).HasValue)
                return;
            // 前序遍历
            if (order == "pre")
                res.Add(val(i).Value);
            dfs(left(i), order, res);
            // 中序遍历
            if (order == "in")
                res.Add(val(i).Value);
            dfs(right(i), order, res);
            // 后序遍历
            if (order == "post")
                res.Add(val(i).Value);
        }

        /* 前序遍历 */
        public List<int> preOrder()
        {
            List<int> res = new List<int>();
            dfs(0, "pre", res);
            return res;
        }

        /* 中序遍历 */
        public List<int> inOrder()
        {
            List<int> res = new List<int>();
            dfs(0, "in", res);
            return res;
        }

        /* 后序遍历 */
        public List<int> postOrder()
        {
            List<int> res = new List<int>();
            dfs(0, "post", res);
            return res;
        }


        static void Main()
        {
            //使用数组实现树结构
            //节点映射公式： 节点 i => 左节点= 2i + 1 => 右节点 2i+2
            //映射公式的角色相当于链表中的指针。给定数组中的任意一个节点，我们都可以通过映射公式来访问它的左（右）子节点

            List<int?> arr = new List<int?> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ArrayBinaryTree binaryTree = new ArrayBinaryTree(arr);

            foreach (int item in binaryTree.preOrder())
            {
                Console.Write(item);
                Console.Write("-");
            }
        }
    }
}
