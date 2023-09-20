using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDiveInto
{
    class EnumAndStruct
    {
    }




    enum Level
    {
        //默认的值
      /*  Boss, //0
        Admin, //1
        Staff //2*/

        //第二种 直接显式
        Boss = 100, 
        Admin= 30,
        Staff=10,
        //如果有的没赋值 那么就再他前一个数+1
        Studnet //默认为11
    }

    //第三种枚举的比特位
    //比如我会其他三个技能或四个
    enum Skill
    {
        Program =1,
        Cook =2,
        Swim = 4
    }
    class Person
    {
        //限制 枚举类似也是值类型

        public int Id { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill Skill { get; set; }
    }

    interface IActivity
    {
        void Run();
    }
    //值类型
    //结构体是值类型，它们在内存中直接存储其值，而不是在堆上分配内存并创建引用。这意味着结构体的实例通常存储在栈上，而不是在堆上，这有助于提高性能
    //结构体可以使用接口
    struct Studnet : IActivity
    {
        //不能显式无参数的构造器
        /*public Studnet()
        {

        }*/
        public int Id { get; set; }
        public string Name { get; set; }

        //但是可以显示的有参数构造器
        public Studnet(string name, int id)
        {
            this.Id = id;
            this.Name = name;
        }


        public void Run()
        {
            Console.WriteLine("我在跑");
        }
    }


    //结构体只能接口 
    //不能类和其他结构体派生而来
    /*struct Test : Studnet
    {

    }*/
}
