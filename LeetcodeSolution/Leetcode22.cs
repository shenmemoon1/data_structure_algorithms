using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode22
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();
            GenerateParenthesisHelper(n, n, "", result);
            return result;
        }

        private static void GenerateParenthesisHelper(int leftCount, int rightCount, string current, IList<string> result)
        {
            // 如果左括号和右括号都用完了，将当前括号组合添加到结果中
            if (leftCount == 0 && rightCount == 0)
            {
                result.Add(current);
                return;
            }

            // 生成左括号
            if (leftCount > 0)
            {
                GenerateParenthesisHelper(leftCount - 1, rightCount, current + "(", result);
            }

            // 生成右括号，但只有在左括号数量大于右括号数量时才添加右括号
            if (rightCount > 0 && leftCount < rightCount)
            {
                GenerateParenthesisHelper(leftCount, rightCount - 1, current + ")", result);
            }
        }
    }
}
