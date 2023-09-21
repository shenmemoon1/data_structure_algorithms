using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiveIntoOOP;

namespace Animal.lib
{
    //例子 加入一个特性 表示还没完成
    [Unfinished]
    class Dog : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("wowo");
            }
        }
    }
}
