using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class Leetcode190ReverseBits
    {
        //solution one(divide and conquer)
        public static uint reverseBits(uint n)
        {
            return (uint)ReverseBits((ulong)n, 32);
        }

        private static ulong ReverseBits(ulong n, int bitSize)
        {
            if (bitSize == 1)
            {
                return n;// 基本情况：如果只有一个位，则直接返回。
            }

            int halfSize = bitSize / 2;
            ulong leftHalf = (n >> halfSize) & ((1UL << halfSize) - 1);
            ulong rightHalf = n & ((1UL << halfSize) - 1);

            ulong reversedLeft = ReverseBits(leftHalf, halfSize);// 递归反转左半部分的位
            ulong reversedRight = ReverseBits(rightHalf, halfSize);// 递归反转右半部分的位

            return (reversedRight << halfSize) | reversedLeft;// 合并反转后的左右半部分
        }

        //solution two
        public uint reverseBits2(uint n)
        {
            n = ((n >> 1) & 0x55555555) | ((n & 0x55555555) << 1);
            n = ((n >> 2) & 0x33333333) | ((n & 0x33333333) << 2);
            n = ((n >> 4) & 0x0F0F0F0F) | ((n & 0x0F0F0F0F) << 4);
            n = ((n >> 8) & 0x00FF00FF) | ((n & 0x00FF00FF) << 8);
            n = (n >> 16) | (n << 16);
            return n;
        }


        //solution three
        /*
         * 1.
         * res = 1
         * 2.
         * res = 1
         */
        public static uint reverseBits3(uint n)
        {
            ulong res = 0;  // 创建一个ulong类型的结果变量，用于存储反转后的值
            int count = 0;  // 创建一个计数器，用于迭代32次，因为输入是32位的无符号整数

            while (count < 32)
            {
                res <<= 1;   // 将结果res向左移动1位，相当于在反转后的数字的右边添加一个位

                res |= (n & 1);  // 使用按位与操作获取n的最低位，并将其设置为res的最低位

                n >>= 1;  // 将n向右移动1位，以准备处理下一位 

                count++;  // 增加计数器，处理下一位
            }

            return (uint)res;  // 返回反转后的32位无符号整数
        }

    }
}
