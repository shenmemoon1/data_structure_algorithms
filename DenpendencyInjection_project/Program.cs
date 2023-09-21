using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Loader;

namespace DenpendencyInjection_project
{
    class Program
    {
        public static object AssenmblyLoadContext { get; private set; }

        static void Main(string[] args)
        {
            // 拼接文件夹路径，这个文件夹包含了动物程序集
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");

            // 获取文件夹中的所有文件
            var files = Directory.GetFiles(folder);

            // 创建一个列表来存储包含"Voice"方法的动物类型
            var animalTypes = new List<Type>();

            // 遍历每个文件
            foreach (var file in files)
            {
                // 加载程序集
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);

                // 获取程序集中的所有类型
                var types = assembly.GetTypes();

                // 遍历每个类型
                foreach (var t in types)
                {
                    // 如果类型包含名为"Voice"的方法，则将其添加到列表中
                    if (t.GetMethod("Voice") != null)
                    {
                        animalTypes.Add(t);
                    }
                }
            }

            while (true)
            {
                // 打印可选的动物类型列表
                for (int i = 0; i < animalTypes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {animalTypes[i].Name}");
                }

                Console.WriteLine("========================================");
                Console.WriteLine("Please choose an animal:");
                int index = int.Parse(Console.ReadLine());

                // 验证用户输入的索引是否有效
                if (index > animalTypes.Count || index < 1)
                {
                    Console.WriteLine("No such an animal! Try Again!");
                    continue;
                }

                Console.WriteLine("How many times:");
                int times = int.Parse(Console.ReadLine());

                // 获取用户选择的动物类型
                var selectedType = animalTypes[index - 1];

                // 获取动物类型中的"Voice"方法
                var voiceMethod = selectedType.GetMethod("Voice");

                // 创建动物类型的实例
                var animalInstance = Activator.CreateInstance(selectedType);

                // 调用"Voice"方法指定的次数
                /*for (int i = 0; i < times; i++)
                {
                    voiceMethod.Invoke(animalInstance, null);
                }*/
                //也可以写成
                voiceMethod.Invoke(animalInstance, new object[] {times});
            }
        }
    }
}
