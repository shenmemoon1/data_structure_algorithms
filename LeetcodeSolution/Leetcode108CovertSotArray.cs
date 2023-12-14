using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode108CovertSotArray
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null;
            return BuildTree(0, nums.Length - 1, nums);
        }

        public TreeNode BuildTree(int left, int right, int[] nums)
        {
            if (left > right) return null;
            int mid = (left + right) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = BuildTree(left, mid - 1, nums);
            root.right = BuildTree(mid + 1, right, nums);
            return root;
        }
    }
}
