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
                return n;
            }

            int halfSize = bitSize / 2;
            ulong leftHalf = (n >> halfSize) & ((1UL << halfSize) - 1);
            ulong rightHalf = n & ((1UL << halfSize) - 1);

            ulong reversedLeft = ReverseBits(leftHalf, halfSize);
            ulong reversedRight = ReverseBits(rightHalf, halfSize);

            return (reversedRight << halfSize) | reversedLeft;
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
        public uint reverseBits3(uint n)
        {
            ulong res = 0;
            int count = 0;
            while (count < 32)
            {
                res <<= 1;  //res 左移一位空出位置
                res |= (n & 1); //得到的最低位加过来
                n >>= 1;//原数字右移一位去掉已经处理过的最低位
                count++;
            }
            return (uint)res;
        }
    }
}
