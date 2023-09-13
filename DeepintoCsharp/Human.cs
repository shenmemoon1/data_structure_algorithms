using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepintoCsharp
{
    class Human
    {
        //字段
        public string name { get; set ;}
        public static int counter=0;
        public readonly string color;

        //静态方法 直接可以调用
        public static void SayHi(string name)
        {
            Console.WriteLine($"hi {name}");
        }
        //构造器
        public Human(string n)
        {
            name = n;
            counter++;
            //只能一次 readonly属性
            color = "blue";
        }
    }
}
