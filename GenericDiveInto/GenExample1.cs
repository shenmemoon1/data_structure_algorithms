using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDiveInto
{
    class GenExample1
    {
    }

    //例子1 为什么要使用泛型
    class Apple
    {
        public string Color { get; set; }
    }

    class Book
    {
        public string  Name { get; set; }
    }

    class Box
    {
        /*public Apple apple { get; set; }

        public void AppleBox() 
        {
            Console.WriteLine($"{apple.Color}");
            Console.WriteLine("apple box");

        }*/

        //使用另外的方法
        public Object Cargo { get; set; }
    }

    /*class Box2
    {
        public Book book { get; set; }

        public void BookBox()
        {
            Console.WriteLine($"{book.Name}");
            Console.WriteLine("book box");

        }
    }*/


    /*
     * 上面两种不管怎么弄都很麻烦
     * 第一总就是给不同的物品什么一个box类 
     * 另外一个是直接使用object 然后强行转换类型
     * 都不理想 接下来使用泛型
     */
    class Box<T>
    {
        public T Cargo { get; set; }
    }

    //例子2 泛型接口
    interface IUnique<T>
    {
        T Id { get; set; }
    }

    //如果这个类使用泛型接口 那种这个类也是泛型类
    //如下
    class Student<T> : IUnique<T>
    {
        public T Id { get; set; }
    }

    //第二种 特化之后的类
    //已经特化不需要
    class Studnet2 : IUnique<ulong>
    {
        public ulong Id { get; set; }
    }

   
}
