using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoOOP
{
    /*
     * 为作基类而生的“抽象类” 与“开发/关闭原则”
     * 相对于virtual 虚方法 abstract 更是一个纯虚方法 因为他并没有实现方法体
     * 开放-封闭原则 (Open-Closed Principle - OCP)：
     * 这个原则表明，软件实体（类、模块、函数等）应该对扩展开放，但对修改关闭。这意味着在添加新功能时，不应该修改现有代码
     * 而是通过扩展现有代码来实现新功能。这可以通过使用抽象类、接口、继承和多态来实现。
     * 设计原则 记住除了修复bug和添加一写新的功能 不应该在基类里面修改代码
     */

    class AbstractExample
    {
    }




    //下面两个违反了设计原则 不能copy  paste
    /*class Car
    {
        public void Run()
        {
            Console.WriteLine("car is runing");
        }

        public void Stop()
        {
            Console.WriteLine("car is stop");
        }
    }

    public class Track 
    {
        public void Run()
        {
            Console.WriteLine("car is runing");
        }

        public void Stop()
        {
            Console.WriteLine("car is stop");
        }
    }*/


    //这个比较老的方式也可以解决

    /* public class Vechi
     {
         public virtual void Run()
         {
             Console.WriteLine("vechi is runing");
         }

         public void Stop()
         {
             Console.WriteLine("car is stop");
         }
     }
     class Car : Vechi
     {
         public override void Run()
         {
             Console.WriteLine("car is runing");
         }
     }

     public class Track : Vechi
     {
         public override void Run()
         {
             Console.WriteLine("trck is runing");
         }
     }*/

    //如果基类方法不适用 最好是使用 abstrct

    /* 
     * 首先abstract如果子类也是抽象类那么子类抽象类可以选择实现或者不是实现父抽象类
     * abstract类可以创建实体和抽象方法
     */
    abstract class People
    {
        abstract public void Stop();
        abstract public void Run();
        abstract public void Dancing();
    }
    abstract class Parent : People
    {
        public override void Run()
        {
            Console.WriteLine("other abstrct class is runing");
        }

    }

    class Son : Parent
    {
        public override void Dancing()
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            Console.WriteLine("son is runing");
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
