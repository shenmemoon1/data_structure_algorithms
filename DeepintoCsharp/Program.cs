using System;

namespace DeepintoCsharp
{
    class Program
    {
        /*
         * "class"（类）是一种用于创建对象的蓝图或模板。
         * 飞行员 <--实例-- 人类
         * 宝马 <--实例--汽车
         */
        static void Main(string[] args)
        {
            //实例了一个对象
            //引用变量
            //Human pilot = new("Kevin");
            //实例2
            //Human p2 = new("lily");
            //每次实例一个就添加一个counter
            //Console.WriteLine(Human.counter);

            //索引器
            Console.WriteLine("--------------------------索引器---------------------------");
            Student s1 = new();
            s1["Math"] = 90;
            var mathScroe = s1["Math"];
            Console.WriteLine(mathScroe);
            Console.WriteLine(mathScroe == null);


            Console.WriteLine("--------------------------值类型---------------------------");
            int x = 100;
            Para para = new(ref s1);
            //实参传递给形参（副本）
            para.AddOne(x);
            //x 并没有修改
            Console.WriteLine(x);
            //同一个内存地址
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.GetHashCode());


            Console.WriteLine("--------------------------引用参数---------------------------");
            int y = 200;
            para.AddTwo(ref y);
            Console.WriteLine(y);

            Console.WriteLine("--------------------------输用参数---------------------------");
            //例子
           /* Console.WriteLine("input a double value: ");
            string arg1 = Console.ReadLine();
            double z = 0;

            // 使用 double.TryParse 尝试将用户输入的字符串转换为 double 类型
            bool b1 = double.TryParse(arg1, out z);

            if (b1 == false)
            {
                Console.WriteLine("input error");
            }

            Console.WriteLine("input a double value: ");
            string arg2 = Console.ReadLine();
            double j = 0;

            // 使用 double.TryParse 尝试将用户输入的字符串转换为 double 类型
            bool b2 = double.TryParse(arg1, out j);

            if (b1 == false)
            {
                Console.WriteLine("input error");
            }
            double q = z + j;

            Console.WriteLine("{0} + {1} = {2}", z, j, q);*/

            Console.WriteLine("-----------------------实现double.parse-------------------------");
            double o = 0;
            bool aa = DoubleParse.TryParser("232", out o);
            Console.WriteLine(o);

            Console.WriteLine("-----------------------数组参数-------------------------");
            //如果没有使用params 还需要声明一个数组传递进去 params放于参数最后一个
            //使用params 直接传递数组 就可以 内部会转换成数组
            int res =calculateSum(1, 2, 3, 4, 5);
            Console.WriteLine(res);

            //另外一个string的数组参数例子
            string nameList = "tom,sdfsd.fgfdg/spdjfsd";
            string[] strList= nameList.Split(',', '.', '/');
            foreach (string item in strList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------具名调用-------------------------");
            //具名调用 就是方法使用参数 不需要按照顺序
            //不具名例子
            printInfo("sfj", 22);
            //具名参数
            printInfo(age: 33, name: "sdfsd");

            Console.WriteLine("-----------------------可选参数-------------------------");
            printInfo(name:"fsd");

            Console.WriteLine("-----------------------扩张方法 this-------------------------");
            //实现了一个round扩张方法
            double pi = 3.14159;
            //必须添加this 在方法的参数里面 才可以使用扩张方法
            double yy = pi.Round(4);
            Console.WriteLine(yy);
        }

        static void printInfo(string name, int age = 22)
        {
            Console.WriteLine("name {0}, age {1}", name, age);
        }

        //使用params 就不需要在调用之前声明一个数组
        static int calculateSum(params int[] array)
        {
            int result = 0;
            foreach (int  item in array)
            {
                result += item;
            }

            return result;
        }


        class DoubleParse
        {
            //自己写一个tryparse
            /// <summary>
            /// 输入值 返回 bool result 如果成功 赋值给外部
            /// </summary>
            public static bool TryParser(string value, out double result)
            {
                try
                {
                    result = double.Parse(value);
                    return true;
                }
                catch
                {
                    result = 0;
                    return false;
                }
            }
        }
    }

    //必须静态类
    static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {
            double res = Math.Round(input, digits);
            return res;
        }
    }
}
