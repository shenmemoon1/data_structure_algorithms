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
            ulong stepCur = 1;
            if (count==1)
            {
                return stepCur;
            }

            ulong totalStep = HanoiCal(count - 1) + stepCur + HanoiCal(count - 1);
            return totalStep;

        }
    }
}
