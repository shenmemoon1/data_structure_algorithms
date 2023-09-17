﻿using System;
using System.Collections;

namespace DiveIntoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化器
            /*Student student = new() { Name= "Bill", Id=343};
            Console.WriteLine(student.Id);*/

            //构造器
            /*Student student = new("bill", 343);
            student.Report();
            Console.WriteLine(Student.Amount);
            Console.ReadLine();*/

           /* Type t = typeof(SubClass);
            Type tb = t.BaseType;
            Console.WriteLine(tb.FullName);

            Console.WriteLine("======================继承=====================");*/
            //是一个  is a
            //从语义上来说 派生类也是基类的一个实例
            //可以是使用父类来创建一个子类实例
            //多态
            /*Inheritance i1 = new SubClass();
            Object o1 = new SubClass();*/

            //seal是封闭类 无法继承

            /*SubClass subClass = new("433");
            Console.WriteLine(subClass.ID);
            subClass.Show();*/


         /*   Console.WriteLine("======================重写和多态=====================");
            Human human = new();
            Teacher teacher = new();
            human.Run();
            teacher.Run();
            Console.WriteLine("======================多态=====================");
            Human t1 = new Teacher();
            t1.Run();

            Human t2 = new Manager();
            t2.Run();*/
            //最好使用teacher 来什么变量类型 继承谁调用谁 
            //因为保证了run是最新的
            //引用谁调谁 引用了manager
           /* Teacher t3 = new Manager();
            t2.Run();*/
            //不使用override的情况 base被隐藏
            /*Manager m = new();
            m.Run();*/

            // 接口和抽象很重要的点
            /*
             * 抽象类除了private 不可以 其他都可以
             * 因为他是基类 用了private就没有意义
             * 接口默认就是public 所以必须public
             * 接口就是契约 contract
             */

            /*Console.WriteLine("======================抽象和开闭原则=====================");
            Parent p = new Son();
            p.Run();

            Console.WriteLine("======================接口=====================");
            int[] nums = { 1, 3, 5, 7, 8 };
            ArrayList a = new ArrayList{ 1, 43, 79 };

            IntefaceExample example = new IntefaceExample();
            Console.WriteLine(example.Sum(nums));
            Console.WriteLine(example.Sum(a));*/

            //例子2
            Engine engine = new Engine();
            Car car = new Car(engine);
            car.Run(3);
            Console.WriteLine("----------------speed---------------------------");
            Console.WriteLine(car.Speed);
            //例子3
            UserPhone user = new UserPhone(new NokiaPhone());
            user.UsePhone();
        }
    }

}
