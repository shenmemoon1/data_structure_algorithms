using System;
using System.Timers;


namespace DiveIntoEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            //事件timer 
            //订阅者boy
            //事件方法是订阅者的方法

            /*Timer timer = new Timer();
            timer.Interval = 1000;
            Boy boy = new();
            Girl girl = new Girl();
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();*/

            //自定义事件

        }
    }


    class Customer 
    {

    }

    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }

    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
