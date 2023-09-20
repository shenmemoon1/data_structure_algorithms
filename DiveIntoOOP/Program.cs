using System;
using System.Collections;

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

            /* Type t = typeof(SubClass);
             Type tb = t.BaseType;
             Console.WriteLine(tb.FullName);

             Console.WriteLine("======================继承=====================");*/
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


            /*   Console.WriteLine("======================重写和多态=====================");
               Human human = new();
               Teacher teacher = new();
               human.Run();
               teacher.Run();
               Console.WriteLine("======================多态=====================");
               Human t1 = new Teacher();
               t1.Run();

               Human t2 = new Manager();
               t2.Run();*/
            //最好使用teacher 来什么变量类型 继承谁调用谁 
            //因为保证了run是最新的
            //引用谁调谁 引用了manager
            /* Teacher t3 = new Manager();
             t2.Run();*/
            //不使用override的情况 base被隐藏
            /*Manager m = new();
            m.Run();*/

            // 接口和抽象很重要的点
            /*
             * 抽象类除了private 不可以 其他都可以
             * 因为他是基类 用了private就没有意义
             * 接口默认就是public 所以必须public
             * 接口就是契约 contract
             */

            /*Console.WriteLine("======================抽象和开闭原则=====================");
            Parent p = new Son();
            p.Run();

            Console.WriteLine("======================接口=====================");
            int[] nums = { 1, 3, 5, 7, 8 };
            ArrayList a = new ArrayList{ 1, 43, 79 };

            IntefaceExample example = new IntefaceExample();
            Console.WriteLine(example.Sum(nums));
            Console.WriteLine(example.Sum(a));*/

            //例子2
            /*Engine engine = new Engine();
            Car car = new Car(engine);
            car.Run(3);
            Console.WriteLine("----------------speed---------------------------");
            Console.WriteLine(car.Speed);
            //例子3
            UserPhone user = new UserPhone(new NokiaPhone());
            user.UsePhone();*/


            /*************************?
             ********* 依赖反转********
             *从本来driver 依赖car的方法
             *到第二种第三种 car必须依赖接口
             *因为必须实现接口方法
            /

            //例子3
            //三种设计模式
            //第一种
            /*
             * 这种模式写了很多的重复代码
             * 不同的车写不同的类
             * 并且高耦合度
             * cardriver基于car
             */
            Console.WriteLine("-----------------设计模式一-------------------");
            CarDriver carDriver = new CarDriver(new Car2());
            ReceDriver receDriver = new ReceDriver(new ReceCar());

            carDriver.Drven();
            receDriver.Driven();


            /*  *第二种写法
              * 单接口模式
              * 汽车和赛车都是车
              * 很多方法一样 然后类进程车这个接口类*/

            Console.WriteLine("-----------------设计模式二-------------------");
            Driver driver = new Driver(new ReceCr());
            driver.Driven();

            /*
            * 第三种写法
            * 多接口模式
            * 不同的司机可以开不同的车
            */
            Console.WriteLine("-----------------设计模式三-------------------");
            new Driver2().Driven(new ReceCr());
            new Driver3().Driven(new Car3());

            Console.WriteLine("-----------------接口自底向上和单元测试-------------------");
            DeskFan deskFan = new DeskFan(new PowerSupply());
            deskFan.Work();

            Console.WriteLine("-----------------接口隔离-------------------");
            //下面这个实例尽管可以使用run方法但是如果我想要catch的是Ifly类型 就得跑去hunter里面修改类型
            //这是没有必要的 并且我只是需要run方法 但是再ifly里还要其他方法 这个接口变成胖接口 因为比不需其他方法
            //提供者不多给 获得者不多要 这个违反了单一职责原则
            new Hunter(new Cat()).Catch();
            //output hunter catch
            //cat is running

            //现在我想要使用IFLY接口的类型 现在只能去修改接口 把接口隔离
            /*
             * 现在把接口隔离 使得IFLY继承其他两个接口 这样子 因为IFLY 继承者IANIMAL 和 IfooD
             * 所有就可以传递不同的类型了
             * 
             */
            new Hunter(new BigBird()).Catch();
            Console.WriteLine("-----------------接口隔离例子2-------------------");
            int[] num = new int[] { 1, 2, 3, 5, 7, 8 };
            var roc = new ReadOnlyCollection(num);
            foreach (var item in roc)
            {
                Console.WriteLine(item);
            }

            //现在调用sum方法 发现新的roc无法使用 因为接口太胖
            //服务提供者不多给 服务需求者不多要
            //ReadOnlyCollection.Sum(roc);
            ReadOnlyCollection.Sum(roc);


            Console.WriteLine("-----------------接口隔离例子3 c#接口显示-------------------");
            WarmKiller warmKiller = new();
            warmKiller.Love();
            //warmKiller.kill();
            //但是我想实现显示接口 只要特殊情况才能调用kill这个方法
            Console.WriteLine("-----------------接口隔离例子3 显示-------------------");
            /*IKiller killer = new WarmKiller();
            killer.kill();*/
            var wk = new WarmKiller();
            IKiller ik = wk;
            ik.kill();
            wk.Love();
        }
    }

}
