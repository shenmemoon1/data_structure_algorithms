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
