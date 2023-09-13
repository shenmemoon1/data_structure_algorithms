using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepintoCsharp
{
    class Human
    {
        private int age;
        //字段
        public static int counter=0;
        public readonly string color;
        //属性写法一
        //public string Name { get; set ;}
        //也可以写成

        //属性封装  
        //写法二
        /*public string GetName()
        {
            return this.name;
        }

        public void SetName(string n)
        {
            if (n.Length < 2)
            {
                throw new Exception("Not Accept");
            }

            this.name = n;
        }*/

        //写法三
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 2)
                { 
                    this.name = value;
                }
                else
                {
                    throw new Exception("Not Accept");
                }
            }
        }

        //  写法四
        public int Age { get => age; set => age = value; }

        //静态方法 直接可以调用
        public static void SayHi(string name)
        {
            Console.WriteLine($"hi {name}");
        }
        //构造器
        public Human(string n)
        {
            Name = n;
            counter++;
            //只能一次 readonly属性
            color = "blue";
        }
        
    }
}
