using System;
using System.Threading;
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


            /*
             * ****事件五大要素
             * 事件拥有者
             * 事件接收者
             * 事件
             * 事件处理器
             * 订阅
             */

            /*
             * 事件声明方式  eg. event orderEventHandler(这是一个自定义) order（事件名）
             * event：这个关键字告诉编译器您正在定义一个事件。
             * OrderEventHandler：这是事件的类型。OrderEventHandler 是一个委托类型，它规定了事件处理程序的方法签名。
             * 委托类型决定了可以订阅事件的方法的参数和返回类型。在这里，OrderEventHandler 表示事件处理程序应该接受两个参数：
             * 一个 object 类型（表示事件的发送者）和一个 OrderEventArgs 类型（表示事件参数），并且不返回任何值。
             * 所以，这行代码的意思是，您正在定义一个名为 order 的公共事件，它将接受具有特定签名的方法作为事件处理程序。
             * 这些事件处理程序将在 order 事件触发时被调用，处理事件相关的逻辑。
             */
            //自定义事件
            Customer customer = new();
            Waiter waiter = new();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayBill();

        }
    }

    //这个是给于委托的参数
    public class OrderEvenArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; } 
    }

    //c#里面专门给事件的用eventhandler结尾
    //委托类和类平级
    public delegate void OrderEventHandler(Customer customer, OrderEvenArgs e);
    //public delegate void AreaEventHandler(int x, int y);
    //这个是给于委托的参数
    public class Customer 
    {
        //委托字段 用来保存事件处理器
        /*private OrderEventHandler orderEventHandler;
        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }

            remove
            {
                this.orderEventHandler -= value;
            }
        }*/

        //简化上面代码
        public event OrderEventHandler Order;


        public double Bill { get; set; }

        public void PayBill()
        {
            Console.WriteLine("Bill is: {0}", this.Bill);
        }

        //触发逻辑
        public void WalkIn()
        {
            Console.WriteLine("Walk into the restaurant");
        }

        public void SitDown()
        {
            Console.WriteLine("Site down");
        }

        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think");
                Thread.Sleep(1000);
            }

            /*if (this.orderEventHandler != null)
            {
                OrderEvenArgs e = new OrderEvenArgs();
                e.DishName = "Fish";
                e.Size = "large";
                this.orderEventHandler.Invoke(this,e);
            }*/

            //简化之后
            if (this.Order != null)
            {
                OrderEvenArgs e = new OrderEvenArgs();
                e.DishName = "Fish";
                e.Size = "large";
                this.Order.Invoke(this, e);
            }
        }

        public void Action()
        {
            Console.ReadLine();
            this.WalkIn();
            this.SitDown();
            this.Think();
        }
    }

    public class Waiter
    {
        public void Action(Customer customer, OrderEvenArgs e)
        {
            Console.WriteLine("i will serve you the dish -{0}", e.DishName);
            double price = 10;

            switch (e.Size)
            {
                case "small":
                    price *= 0.5;
                    break;
                case "large":
                    price *= 0.9;
                    break;
                default:
                    break;
            }

            customer.Bill += price;

        }
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
