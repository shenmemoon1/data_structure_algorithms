using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoDelegate
{
    class TestDel
    {
        public static void report()
        {
            Console.WriteLine("hello delegate");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }


    }
}
