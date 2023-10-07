using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class HanoiStepCalculate
    {
        public static ulong HanoiCal(int count)
        {
            ulong stepCur = 1; // 初始化当前步数为1，表示将一个盘子从起始柱移动到目标柱的步数
            if (count == 1) // 如果只有一个盘子，直接返回步数1
            {
                return stepCur;
            }

            // 使用递归计算总步数：
            // 1. 先将 count - 1 个盘子从起始柱经过目标柱移动到辅助柱，总步数为 HanoiCal(count - 1)
            // 2. 然后将最后一个盘子从起始柱移动到目标柱，步数为 stepCur
            // 3. 最后再将 count - 1 个盘子从辅助柱经过起始柱移动到目标柱，总步数为 HanoiCal(count - 1)
            ulong totalStep = HanoiCal(count - 1) + stepCur + HanoiCal(count - 1);

            return totalStep; // 返回总步数
        }

    }
}
