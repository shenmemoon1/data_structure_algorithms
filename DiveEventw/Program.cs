using System;

namespace DiveEventw
{
    class Program
    {
        static void Main(string[] args)
        {
            //发布者
            ExplainEvent explainEvent = new();
            //订阅者
            Subscr1 subscr1 = new();
            Subscr2 subscr2 = new();
            //事件 订阅 事件处理器
            explainEvent.OnCounter += subscr1.Action;
            explainEvent.OnCounter += subscr2.Action;
            //invoke 事件
            explainEvent.Action();
        }
    }
}
