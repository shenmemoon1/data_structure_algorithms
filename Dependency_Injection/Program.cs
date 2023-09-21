using System;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 其实依赖注入就是一个类似箱子 然后往里面装你要的服务
             * 当想要某个服务。直接使用getserive这个钥匙去打开并使用就好了
             * 某种意义是有点像react context这种
             */
            /*
             * 下面的例子中如果是日常的话还需要什么一个drive 然后传入一个IVehicle类型实例
             * 但是使用DI之后 服务会根据上下文去箱子里面寻找依赖
             */
            var sc = new ServiceCollection();
            //sc.AddScoped(typeof(IVehicle), typeof(Truck));
            //这两者方式都是可以的
            sc.AddScoped<IVehicle, Car>();
            //sc.AddScoped(typeof(Driver));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();
            //使用getservice<>泛型更好的可读性
            //也可以使用第二中
            Driver driver = sp.GetService<Driver>();
            //Driver driver = (Driver)sp.GetService(typeof(Driver));

            driver.Driven();
        }
    }

    public interface IVehicle
    {
        void Run();
    }

    public class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("car is running");
        }
    }

    public class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("truck is running");
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
            vehicle.Run();
        }
    }
}
