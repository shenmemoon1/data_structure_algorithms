using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode112PathSum
    {
        // 判斷是否存在從根節點到葉子節點的路徑，使得路徑上節點值的總和等於給定的目標和
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            // 如果根節點為空，返回 false
            if (root == null)
                return false;

            // 呼叫輔助函數進行遞歸判斷
            return HasPathSumHelper(root, targetSum);
        }

        // 輔助函數，遞歸地檢查從給定節點到葉子節點的路徑是否存在指定目標和
        public bool HasPathSumHelper(TreeNode node, int sum)
        {
            // 如果節點為葉子節點，判斷節點值是否等於目標和
            if (node.left == null && node.right == null)
            {
                return node.val == sum;
            }

            // 如果左子節點為空，遞歸檢查右子樹
            if (node.left == null)
            {
                return HasPathSumHelper(node.right, sum - node.val);
            }

            // 如果右子節點為空，遞歸檢查左子樹
            if (node.right == null)
            {
                return HasPathSumHelper(node.left, sum - node.val);
            }

            // 如果左右子節點都存在，遞歸檢查左右子樹
            return HasPathSumHelper(node.left, sum - node.val) || HasPathSumHelper(node.right, sum - node.val);
        }

    }
}
