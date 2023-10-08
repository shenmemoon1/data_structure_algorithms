using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DivideAndConquer;

namespace BackTrackingAlgo
{
    class OptimizationBinarybacktracking
    {
        /* 判断当前状态是否为解 */
        public static bool isSolution(List<TreeNode> state)
        {
            
            return state.Count != 0 && state[^1].value == 7;
        }

        /* 记录解 */
        public static void recordSolution(List<TreeNode> state, List<List<TreeNode>> res)
        {
            res.Add(new List<TreeNode>(state));
        }

        /* 判断在当前状态下，该选择是否合法 */
        public static bool isValid(List<TreeNode> state, TreeNode choice)
        {
            return choice != null && choice.value != 3;
        }

        /* 更新状态 */
        public static void makeChoice(List<TreeNode> state, TreeNode choice)
        {
            state.Add(choice);
        }

        /* 恢复状态 */
        public static void undoChoice(List<TreeNode> state, TreeNode choice)
        {
            state.RemoveAt(state.Count - 1);
        }

        /* 回溯算法：例题三 */
        public static void backtrack(List<TreeNode> state, List<TreeNode> choices, List<List<TreeNode>> res)
        {
            // 检查是否为解
            if (isSolution(state))
            {
                // 记录解
                recordSolution(state, res);
            }
            // 遍历所有选择
            foreach (TreeNode choice in choices)
            {
                // 剪枝：检查选择是否合法
                if (isValid(state, choice))
                {
                    // 尝试：做出选择，更新状态
                    makeChoice(state, choice);
                    // 进行下一轮选择
                    backtrack(state, new List<TreeNode> { choice.left, choice.right }, res);
                    // 回退：撤销选择，恢复到之前的状态
                    undoChoice(state, choice);
                }
            }
        }

    }
}
