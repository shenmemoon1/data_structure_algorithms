using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoOOP
{
    //类是一个类型 引用类型 具体到每个类上 每一个类都是一个自定义类型
    //在C#中，一个类可以拥有多个构造函数，包括实例构造函数和静态构造函数。这些构造函数用于创建类的实例和初始化静态成员，它们可以一起存在。
    //puhlic 类访问级别 可以访问所有项目 internal 项目访问基本 只能访问项目里面的
    class Student
    {
        //属性
        public int Id { get; set; }
        public string Name { get; set; }

        //构造器
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        //静态成员
        public static int Amount {get; set;}
        //静态构造器
        //用来初始化静态成员
        static Student()
        {
            Amount = 100;
        }


        //析构器
        //当没有对象引用 GC（垃圾回收）
        //释放资源
        ~Student(){
            Console.WriteLine("bye! release the system resources");
        }


        //方法
        public void Report()
        {
            Console.WriteLine($"name: {Name} ID: {Id}");
        }

        //成员类
        class SecondaryStudent
        {

        }
    }
}
