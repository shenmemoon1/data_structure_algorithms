using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoOOP
{
    class OverrideExample
    {

    }


    public class Human
    {
        //虚函数(名存实亡) 子类可以重写
        //纵向扩张
        public virtual void Run()
        {
            Console.WriteLine("i am human");
        }
    }

    public class Teacher : Human
    {
        //我有自己的想法
        /*
         * 如果不适用override会出现什么问题
         * 对 就是因为多态的原因只能 还是打印了基类的方法
         *可以理解为不适用override 造成子类的run和基类的run并没有关联 所以无法overrride
         *也就是子类的run被隐藏了 还是调用父类
         *多态就是父类条用子类 然后会先去看子类有没有重写方法 如果没有调用父类
         */
        [Description("This method performs a specific operation.")]
        public override void Run()
        {
            Console.WriteLine("i am teacher");
        }
    }

    public class Manager : Teacher
    {
        public override void Run()
        {
            Console.WriteLine("i am manager");
        }
    }
}
