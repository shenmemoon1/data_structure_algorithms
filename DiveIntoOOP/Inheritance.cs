using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoOOP
{
    //类的继承
    //所有类都继承于object
    //一个类只有有一个父类
    //但是可以有多个基接口
    //子类的访问修饰符不能超过父类
    //父类 intrnal 之类只能程序集级别
    //父类有什么 子类全部继承
    //继承只多不少 字面上就是继承是纵向的 当引入一个继承 后期很多子类就会派生 这时候就不能移除基类从继承链 或者说不能移除继承成员
    //内成员默认internal
    //类的访问级别是内成员的上限 就算类成员是public 也无法超过internal 这个已设置的类
    //internal是程序集别 不可跨程序集
    //public项目级别
    //private 限制到 {}符号 
    //protect 可以跨程序集 但是只能继承链上的子类访问

    //总结 
    /* public 我有钱 我哪里都能去 没有限制
     * internal 我家附近的地我都能用
     * private  我的房间除了我 谁都不能进
     * protect  我爸的家产我都能用 不管我在哪里哪个国家
     */
    public class Inheritance
    {
        public string ID { get; set; }
        //子类无法访问 尽管继承了  但是private被限制在{}符号里
        private int Num { get; set; }
        //只能继承访问
        protected string Name { get; set; }
        /*public Inheritance()
        {
            this.ID = "NA";
        }*/
        public Inheritance(string id)
        {
            this.ID = id;
        }
    }

    //sub继承inherited
    public class SubClass : Inheritance
    {
        /*public SubClass()
        {
            this.ID = "OWNERE";
        }*/

        //子类直接使用base关键字来调用基类的构造器
        //使用 base 关键字来调用基类（父类）的构造函数，并传递一个名为 id 的参数。
        public SubClass(string id) : base(id)
        {
        }

        public void Show()
        {
            //两者都一样
            //base 只能访问它的上一层
            /* Console.WriteLine(this.ID);
             Console.WriteLine(base.ID);*/
            //Console.WriteLine(this.Num);
        }
    }

    //设置为封闭类 无法被继承
  /*  public sealed class Vehicle
    {

    }

    public class Bus : Vehicle
     {

    }*/
}
