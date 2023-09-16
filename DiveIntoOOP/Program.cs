using System;

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

            Type t = typeof(SubClass);
            Type tb = t.BaseType;
            Console.WriteLine(tb.FullName);

            Console.WriteLine("======================继承=====================");
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
        }
    }

}
