using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class leetcode168
    {
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder result = new StringBuilder();

            while (columnNumber > 0)
            {
                columnNumber--;  // 将 columnNumber 减去 1，使得映射从 0 开始
                char digit = (char)('A' + columnNumber % 26);  // 计算最低位的值，并映射为字母
                result.Insert(0, digit);  // 将结果加到最前面
                columnNumber /= 26;  // 更新 columnNumber 为商，继续处理更高位
            }

            return result.ToString();
        }
    }
}
