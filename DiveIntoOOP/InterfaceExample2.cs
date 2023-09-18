using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoOOP
{
    class InterfaceExample2
    {
    }

    //三种设计模式
    //第一种
    public class CarDriver
    {
        private Car2 car;
        public CarDriver(Car2 car)
        {
            this.car = car;
        }

        public void Drven()
        {
            car.Run();
        }
    }

    public class Car2
    {
        public void Run()
        {
            Console.WriteLine("car2 is runing");
        }
    }

    public class ReceDriver
    {
        private ReceCar receCar;
        public ReceDriver(ReceCar receCar)
        {
            this.receCar = receCar; 
        }

        public void Driven()
        {
            receCar.Run();
        }
    }

    public class ReceCar
    {
        public void Run()
        {
            Console.WriteLine("ReceCar is runing");
        }
    }
    //第二种
    //单接口模式
    public interface IVehicle
    {
        void Run();
    }

    public class Car3 : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("car is running");
        }
    }

    public class ReceCr : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("rece car is running");
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
            this.vehicle.Run();
        }
    }

    //模式3
    public interface IDriver
    {
        void Driven(IVehicle vehicle);
    }

    public class Driver2 : IDriver
    {
        public void Driven(IVehicle vehicle)
        {
            Console.WriteLine("driver 2 drive");
            vehicle.Run();
        }
    }

    public class Driver3 : IDriver
    {
        public void Driven(IVehicle vehicle)
        {
            Console.WriteLine("driver e drive");
            vehicle.Run();
        }
    }


}
