using System;

namespace DeepintoCsharp
{
    class Program
    {
        /*
         * "class"（类）是一种用于创建对象的蓝图或模板。
         * 飞行员 <--实例-- 人类
         * 宝马 <--实例--汽车
         */
        static void Main(string[] args)
        {
            //实例了一个对象
            //引用变量
            //Human pilot = new("Kevin");
            //实例2
            //Human p2 = new("lily");
            //每次实例一个就添加一个counter
            //Console.WriteLine(Human.counter);

            //索引器
            Student s1 = new();
            s1["Math"] = 90;
            var mathScroe = s1["Math"];
            Console.WriteLine(mathScroe);
            Console.WriteLine(mathScroe == null);
        }
    }
}
