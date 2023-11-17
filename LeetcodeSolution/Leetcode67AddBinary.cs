using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolution
{
    class Leetcode67AddBinary
    {
        public static string AddBinary(string a, string b)
        {
            int parseA = Convert.ToInt32(a, 2); // 将二进制字符串转换为整数
            int parseB = Convert.ToInt32(b, 2);

            int carry = 0; // 进位
            string sum = "";

            while (parseA > 0 || parseB > 0 || carry > 0)
            {
                int bitA = parseA & 1; // 取 a 的最低位
                int bitB = parseB & 1; // 取 b 的最低位

                int currentSum = bitA + bitB + carry; // 当前位的和
                sum = (currentSum % 2) + sum; // 将当前位的结果拼接到 sum 的前面
                carry = currentSum / 2; // 计算进位

                parseA >>= 1; // 右移一位，相当于除以 2
                parseB >>= 1;
            }

            return sum;
        }


        public static string AddBinary2(string a, string b)
        {
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;
            StringBuilder res = new StringBuilder();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';

                res.Insert(0, sum % 2);
                carry = sum / 2;
            }

            return res.ToString();
        }


    }
}
