using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericDiveInto
{
    class Program
    {
        static void Main(string[] args)
        {
            //不理性的两种方式
            /*Apple apple = new Apple() { Color = "red"};
            Box box = new Box() { Cargo = apple };
            Book book = new() { Name = "three hand shake"};
            Console.WriteLine((box.Cargo as Apple)?.Color);*/
            //Box2 box2 = new() { book = book };
            //output
            //box.AppleBox();
            //box2.BookBox();

            //泛型
            //解决了类型转换和成员膨胀问题
            Apple apple = new() { Color = "red" };
            Book book = new() { Name = "three hand shake" };
            Box<Apple> box = new() { Cargo = apple };
            Box<Book> box2 = new() { Cargo = book };
            Console.WriteLine(box.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);

            Console.WriteLine("---------------泛型类-------------------");
            Student<int> student = new() { Id = 32423 };
            Console.WriteLine(student.Id);

            IList<int> list = new List<int>();
            IDictionary<string, int> keyValues = new Dictionary<string, int>();

            //Sum(1, 2);

            Console.WriteLine("============泛型委托==================");
            Action<string> action = Say;
            action.Invoke("Bill");

            Func<int, int, int> func = Add;
            Console.WriteLine(func.Invoke(100, 300)) ;
        }

        //泛型委托
        //action
        public static void Say(string name)
        {
            Console.WriteLine("hello {0}",name);
        }
        //func
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //写一个泛型方法
       /* public static T Sum<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            dynamic z = x + y;
            return z;
        }*/
    }
}
