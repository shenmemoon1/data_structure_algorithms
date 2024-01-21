using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class leetcode145
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();

            IList<int> posList = new List<int>();
            PostorderTra(root, posList);
            return posList;
        }

        public void PostorderTra(TreeNode node, IList<int> path)
        {

            //end condition
            if (node == null) return;
            //left - right -root
            PostorderTra(node.left, path);
            PostorderTra(node.right, path);

            path.Add(node.val);
        }
    }
}
