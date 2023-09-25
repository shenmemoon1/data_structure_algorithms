using System;
using System.Reflection;
using DiveIntoOOP;
using Microsoft.Extensions.DependencyInjection;

namespace DiveIntoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            IFly fly = new BigBird();
            Console.WriteLine("------------反射开始--------------------");

            // 获取对象的类型信息
            var f = fly.GetType();

            // 使用 Activator 创建对象的实例
            object o = Activator.CreateInstance(f);

            // 使用反射获取名为 "Run" 的方法信息
            MethodInfo run = f.GetMethod("Run");

            // 使用反射获取名为 "Eat" 的方法信息
            MethodInfo eat = f.GetMethod("Eat");

            // 使用反射调用 "Run" 方法
            run.Invoke(o, null);

            // 使用反射调用 "Eat" 方法
            eat.Invoke(o, null);

            Console.WriteLine("------------依赖注入--------------------");

            var sc = new ServiceCollection();
            sc.AddScoped(typeof(IFly), typeof(BigBird));
            sc.AddScoped(typeof(IVehicle), typeof(SmallCar));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();

            //+=====================================分割线==============================================
            /*
             * ServiceCollection 是一个用于配置和注册依赖项的服务集合，通常在应用程序的启动阶段使用。

            sc.AddScoped(typeof(IFly), typeof(BigBird)) 注册了一个服务，将接口 IFly 与具体实现类 BigBird 关联。这意味着当请求 IFly 接口时，依赖注入容器会提供 BigBird 类的实例。

            sc.AddScoped(typeof(IVehicle), typeof(SmallCar)) 同样，这里注册了 IVehicle 接口与 SmallCar 类的关联。

            sc.AddScoped<Driver>() 注册了 Driver 类，不需要指定接口，因为 Driver 的构造函数中接受一个 IVehicle 参数，容器会根据前面的注册自动解析 IVehicle 依赖。

            var sp = sc.BuildServiceProvider() 创建了一个 ServiceProvider，该服务提供者包含了注册的所有依赖项。

            sp.GetService<Driver>() 从服务提供者中获取了一个 Driver 对象，这个对象的构造函数将自动注入一个与 IVehicle 接口关联的对象（SmallCar 类的实例）。

            driver.Driven() 调用了 Driver 类中的 Driven 方法，这个方法输出 "driver e drive" 并调用了注入的 IVehicle 对象的 run 方法。

            IFly fly1 = sp.GetService<IFly>() 获取了一个 IFly 接口的实例，这里的 IFly 是通过容器配置与 BigBird 类关联的。

            fly1.Eat() 和 fly1.Run() 调用了 IFly 接口的方法，实际上是调用了 BigBird 类的相应方法。
             */

            var driver = sp.GetService<Driver>();
            driver.Driven();
            IFly fly1 = sp.GetService<IFly>();
            fly1.Eat();
            //fly1.Run();
        }
         
    }

    public interface IVehicle
    {
        void run();
    }
    public class bigCar : IVehicle
    {
        public void run()
        {
            Console.WriteLine("big car run");
        }
    }

    public class SmallCar : IVehicle
    {
        public void run()
        {
            Console.WriteLine("small car run");
        }
    }
    public class Driver 
    {
        private IVehicle vehicle;

        public Driver(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public void Driven()
        {
            Console.WriteLine("driver e drive");
            vehicle.run();
            
        }
    }

}
