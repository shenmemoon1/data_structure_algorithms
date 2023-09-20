using System;

namespace DelegateGenericAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele myDele = new MyDele(SayHello);
            myDele += (new Student().sayHello);
            //可以+=多个委托 
            myDele.Invoke();

            //泛型委托
            Console.WriteLine("========================泛型委托========================");
            MyDele2<int> myDele2 = Add;
            int res = myDele2(2, 4);
            Console.WriteLine(res);
            MyDele2<double> myDele21 = Mul;
            double res2=  myDele21.Invoke(2.2, 4.5);
            Console.WriteLine(res2);

            Console.WriteLine("========================委托Lambda========================");
            //匿名函数简化
            //inline method
            MyDele myDele1 = () => Console.WriteLine("hwllo wolrd");
            myDele1();

            Func<int, int, int> func = (int a, int b) => a + b;
            /*int res3 = func(2,4);
            Console.WriteLine(res);*/

            //把委托作为函数指针使用
            DoSomeCal<int>((int a, int b) =>  a +b,100,200);

            Console.WriteLine("========================委托Lambda========================");
            //linq 
            //必学SQL
            //无法创建data类
            //接下来伪代码
            var dbContext = new AdventureWorks2013Entities();
            //var allPeople = dbContext.People.ToList();
            //linq语法
            //就是类似SQL
            var allPeopleFirstName = dbContext.People.Select(p=>p.FirstName).ToList();

            /*foreach (var item in allPeople)
            {
                Console.WriteLine(item.FirstName);
            }*/

        }

        static void DoSomeCal<T>(Func<T,T,T> func,T x, T y)
        {
            T res4 = func(x,y);
            Console.WriteLine(res4);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Mul(double a, double b)
        {
            return a * b;
        }



        public static void SayHello()
        {
            Console.WriteLine("hello");
        }
    }
    class Student
    {
        public void sayHello()
        {
            Console.WriteLine("student hello");
        }
    }

    delegate void MyDele();

    delegate T MyDele2<T>(T a, T b);
}
