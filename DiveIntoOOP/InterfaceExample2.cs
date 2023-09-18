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
}
