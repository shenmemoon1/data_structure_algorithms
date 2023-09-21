using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoOOP
{
    class InterfaceSegregation
    {
    }

    class ReadOnlyCollection : IEnumerable
    {
        private int[] _array;
        public ReadOnlyCollection(int[] array)
        {
            _array = array;
        }

        //public static int Sum(ICollection collection)
        public static int Sum(IEnumerable collection)
        {
            int sum = 0;
            foreach (int item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public IEnumerator GetEnumerator() 
        {
            return new Enumerateor(this);
        }

        class Enumerateor : IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head;

            public Enumerateor(ReadOnlyCollection collection)
            {
                _collection = collection;
                _head = -1;
            }
            public object Current
            {
                get
                {
                    object o = _collection._array[_head];
                    return o;
                }
            }

            public bool MoveNext()
            {
                if (++_head < _collection._array.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                _head = -1;
            }
        }
    }

    public interface IAnimal
    {
        //void Run();
        //这个是gei sdk例子使用
        void Voice(int times);
    }

    //Interface segregation principle
    //接口隔离原则就是把不同的方法隔离成小份
    public class Cat : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("cat is running");
        }
    }

    public class Dog : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("dog is running");
        }
    }

    public interface IFood
    {
        void Eat();
    }

    public interface IFly : IAnimal, IFood
    {
    }

    public class BigBird : IFly
    {
        public void Eat()
        {
            Console.WriteLine("big bird eating");
        }

        public void Run()
        {
            Console.WriteLine("big bird flying");
        }
    }

    public class MidBird : IFly
    {
        public void Eat()
        {
            Console.WriteLine("meidum bird eating");
        }

        public void Run()
        {
            Console.WriteLine("meidum bird flying");
        }
    }
    public class SmallBird : IFly
    {
        public void Eat()
        {
            Console.WriteLine("small bird eating");
        }

        public void Run()
        {
            Console.WriteLine("small bird flying");
        }
    }

    public class Hunter
    {
        private IAnimal _animal;
        public Hunter(IAnimal animal)
        {
            _animal = animal;
        }

        public void Catch()
        {
            Console.WriteLine("hunter catch");
            _animal.Run();
        }
    }

    interface IKiller
    {
        void kill();
    }

    interface ILover
    {
        void Love();
    }

    public class WarmKiller : ILover, IKiller
    {
        /*public void kill()
        {
            Console.WriteLine("killer kill a emermy");
        }*/

        //显示

        public void Love()
        {
            Console.WriteLine("killer is a lover");
        }

        void IKiller.kill()
        {
            Console.WriteLine("killer kill a emermy");
        }
    }

}
