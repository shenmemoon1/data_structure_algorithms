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

            //Console.WriteLine("============lambda==================");
            Console.WriteLine("=--------------------------------枚举---------------------------------");

            Person person = new() { Id = 2, Name = "dfd", Level=Level.Boss};
            //person.Skill = Skill.Program | Skill.Cook;
            // 将技能属性设置为 Program（编程） | Cook（烹饪） | Swim（游泳）
            person.Skill = Skill.Program | Skill.Cook;
            //会其中的两个
            Console.WriteLine(person.Skill);
            // 检查人是否具备 Cook（烹饪）技能
            // 这里使用位运算 & 操作来检查，如果结果大于 0，则表示具备该技能
            Console.WriteLine((person.Skill & Skill.Cook) > 0);
            Console.WriteLine("=--------------------------------struct----------------------------");
            Studnet student1 = new Studnet() { Id=3,Name="bill"};
            //把stud net这个类copy 然后他copy的放进堆里面

            //======================================总结 结构体==============================================
            //除了继承接口 其他都不行
            //不能使用无参构造 但是可以使用有参构造器
            //装箱
            object obj = student1;
            //拆箱
            Studnet studnet = (Studnet)obj;
            Console.WriteLine(studnet.Name);
            studnet.Run();

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

        //lambda
        //public int Mul(int a, int b) => a + b;

    }
}
