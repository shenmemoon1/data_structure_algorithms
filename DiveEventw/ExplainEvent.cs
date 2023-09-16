using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveEventw
{

    public delegate void CounterEventHandler(ExplainEvent explainEvent);
    public class ExplainEvent
    {
        //发布者(publisher) 发布某个事件的类或结构 其他类可以在该事件得到通知
        //订阅者(subscriber) 注册并在事件发生时通知的类和结构
        //事件处理程序 (event handler) 由订阅者注册到事件的方法 在发布者触发事件执行
        //触发（raise）事件 调用（invoke）或触发（fire）的术语 但事件触发 所有注册到它的方法都会依次调用
        //
        public int Counter { get; set; }
        //声明事件
        public event CounterEventHandler OnCounter;

        public void Action()
        {
            if (this.OnCounter!=null)
            {
                Console.WriteLine("start check income:");
                this.OnCounter.Invoke(this);
                Console.ReadLine();
            }
        }
    }

    public class Subscr1
    {
        internal void Action(ExplainEvent explainEvent)
        {
            explainEvent.Counter += 10;
            Console.WriteLine("From shop one counter is: {0}",explainEvent.Counter);
        }
    }

    public class Subscr2
    {
        internal void Action(ExplainEvent explainEvent)
        {
            explainEvent.Counter += 50;
            Console.WriteLine("From shop two counter is: {0}", explainEvent.Counter);
        }
    }
}


