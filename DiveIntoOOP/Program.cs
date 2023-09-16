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
            Student student = new("bill", 343);
            student.Report();
            Console.WriteLine(Student.Amount);
            Console.ReadLine();
        }
    }
}
