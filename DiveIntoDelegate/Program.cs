using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiveIntoDelegate
{
    delegate void MyDelegate();
    delegate int CalDelegate(int x, int y);
    class Program
    {
        static async Task Main(string[] args)
        {
            Action action = new Action(TestDel.report);
            //直接调用
            TestDel.report();
            //action 调用
            action.Invoke();
            //简化
            action();

            //func 委托
            int x = 100;
            int y = 200;
            Func<int, int, int> func1 = new Func<int, int, int>(TestDel.Add);
            int a = func1(x, y);
            Console.WriteLine(a);

            //自定义delegeate
            Console.WriteLine("------------------自定义委托----------------------");
            MyDelegate myDelegate = new MyDelegate(TestDel.report);
            myDelegate();
            CalDelegate calDelegate = new CalDelegate(TestDel.Sub);
            int b = calDelegate(x, y);
            Console.WriteLine(b);

            Console.WriteLine("------------------实际委托例子----------------------");
            ProductFactory productFactory = new ProductFactory();
            WrapProduct wrapProduct = new WrapProduct();
            Logger logger = new();

            Func<Product> fu1 = new Func<Product>(productFactory.makeToyCar);
            Func<Product> fu2 = new Func<Product>(productFactory.makeKingKong);

            Box box1 = wrapProduct.WrapPro(fu1,logger.Log);
            Box box2 = wrapProduct.WrapPro(fu2, logger.Log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);

            Console.WriteLine("------------------单播委托例子----------------------");
            Student stu1 = new() { Id = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new() { Id = 2, PenColor = ConsoleColor.Red };
            Student stu3 = new() { Id = 3, PenColor = ConsoleColor.Blue };

            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);
            //同步单播
            /*action1.Invoke();
            action2.Invoke();
            action3.Invoke();*/
            //异步单播
            /*Thread thread1 = new Thread(stu1.DoHomework);
            Thread thread2 = new Thread(stu2.DoHomework);
            Thread thread3 = new Thread(stu3.DoHomework);*/

            /* thread1.Start();
             thread2.Start();
             thread3.Start();*/
            Console.WriteLine("------------------多播委托例子----------------------");
            //同步多播
            /*action1 += action2;
            action1 += action3;

            action1.Invoke();*/

            Console.WriteLine("------------------TASK lock的作用----------------------");

            var account = new TaskLock(1000);
            var tasks = new Task[100];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => Update(account));
            }
            await Task.WhenAll(tasks);
            Console.WriteLine($"Account's balance is {account.GetBalance()}");
            // Output:


        }
        static void Update(TaskLock account)
        {
            decimal[] amounts = { 0, 2, -3, 6, -2, -1, 8, -5, 11, -6 };
            foreach (var amount in amounts)
            {
                if (amount >= 0)
                {
                    account.Credit(amount);
                }
                else
                {
                    account.Debit(Math.Abs(amount));
                }
            }
        }


        class Logger
        {
            public void Log(Product product)
            {
                Console.WriteLine("product: {0} created at {1} price is {2}", product.Name, DateTime.UtcNow, product.Price);
            }
        }

        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }


        class ProductFactory
        {
            public  Product makeToyCar()
            {
                Product product = new();
                product.Name = "Toy Car";
                product.Price = 22;
                return product;
            }

            public  Product makeKingKong()
            {
                Product product = new();
                product.Name = "king kong";
                product.Price = 60;
                return product;
            }
        }


        class Box
        {
            public Product Product { get; set; }
        }

        class WrapProduct
        {
            public Box WrapPro(Func<Product> getProdect, Action<Product> callbackAction)
            {
                Box box = new();
                Product product = getProdect.Invoke();
                if (product.Price > 50)
                {
                    callbackAction(product);
                }
                box.Product = product;
                return box;
            }

        }

        class Student
        {
            public int Id { get; set; }
            public ConsoleColor PenColor { get; set; }

            public void DoHomework()
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.ForegroundColor = this.PenColor;
                    Console.WriteLine($"student {Id}--{i} hour(s)");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
 