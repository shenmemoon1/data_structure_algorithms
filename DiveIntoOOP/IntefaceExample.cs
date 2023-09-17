using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoOOP
{
    
    class IntefaceExample
    {
        //关于接口的契约例子
        //在这里会一个sum 我给的是int[]数组 
        //但是如果我使用的是arrayLIST 那么我还需要写一个sum来计算arralist的sum
        //编程原理不复制代码 所以这个使用我可以使用Imenurable 作为类型
        //因为他们是可迭代的
        /*
         * 当一个类继承了一个接口（实际上应该说是实现了一个接口），这意味着该类的实例也可以被视为该接口的实例。这是因为该类必须实现接口中定义的所有成员（方法、属性、事件等）
         * 在语义上，一个类的实例在实现了某个接口后，可以被视为拥有该接口的所有特性。这意味着你可以将该类的实例赋值给接口类型的变量，然后使用该变量来访问接口中定义的成员。
         */
        /*public int Sum(int[] nums)
        {
            int n = 0;
            foreach (int item in nums)
            {
                n += item;
            }

            return n;
        }
        */

        public int Sum(IEnumerable nums)
        {
            int n = 0;
            foreach (int item in nums)
            {
                n += item;
            }

            return n;
        }
    }


    public class Engine
    {
        //转速
        public int RPM { get; private set; }
        public void Work(int gas)
        {
            this.RPM = 1000 * gas;
        }
    }

    public class Car
    {
        private Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }

        public int Speed { get; private set; }

        public void Run(int gas)
        {
            _engine.Work(gas);
            this.Speed = _engine.RPM / 100;
        }
    }

    //接口用于解耦
    interface IPHONE
    {
        void Dail();
        void Pickup();
        void Send();
        void Receive();
    }

    class UserPhone
    {
        private IPHONE _phone;
        public UserPhone(IPHONE phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.Receive();
            _phone.Pickup();
            _phone.Send();
        }
    }


    class NokiaPhone : IPHONE
    {
        public void Dail()
        {
            Console.WriteLine("nokia is calling");
        }

        public void Pickup()
        {
            Console.WriteLine("here is Bill");
        }

        public void Receive()
        {
            Console.WriteLine("nokia receive message");
        }

        public void Send()
        {
            Console.WriteLine("nokia sent message");
        }
    }

    class Sangsong : IPHONE
    {
        public void Dail()
        {
            Console.WriteLine("sangsong is calling");
        }

        public void Pickup()
        {
            Console.WriteLine("here is Bill");
        }

        public void Receive()
        {
            Console.WriteLine("sangsong receive message");
        }

        public void Send()
        {
            Console.WriteLine("sangsong sent message");
        }
    }
}
