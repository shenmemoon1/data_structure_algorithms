using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepintoCsharp
{
    class Para
    {
        /*传值参数-->值参数（创建变量的副本，并不影响对变量的改变）
         * 引用传值参数主要的作用是复制的是内存地址
         * 如图
         * a => 0x3436546(地址)
         *           /\
         * a ----| 直接指向内存，所以当ref值修改了 原来的值就修改了
         * 参数修饰符 
         * ref 要初始化 out不需要
         * ref 参数（Reference Parameter）： 使用 ref 修饰符传递参数时，方法接收的是参数的引用，而不是值的副本。这允许在方法内部修改参数的值，并且这些修改会影响原始参数的值。
         * out 参数（Output Parameter）： 使用 out 修饰符传递参数时，方法接收的是参数的引用，并且方法负责为该参数赋值。在方法内部，必须确保为 out 参数分配一个值。
         */
        public Para(Student stu)
        {
            stu.Name = "Kevin";
            Console.WriteLine(stu.GetHashCode());
        }

        public void AddOne(int x)
        {
            x += 1;
            Console.WriteLine(x);
        }
    }
}
