using System;

namespace c_sharp_learning
{
    public delegate int MyDelegate(int a, int b);


    public class MyClass
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int multipulation(int a, int b)
        {
            return a * b;
        }


    }


    class Program
    {

        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            MyDelegate myDelegate = new MyDelegate(obj.add);

            int res = myDelegate(22,33);

            Console.WriteLine(res);
        }
    }
}
