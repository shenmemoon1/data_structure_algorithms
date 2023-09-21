using System;
using DiveIntoOOP;

namespace Animal.lib
{
    public class Cat : IAnimal
    {

        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("whew");
            }
        }
    }
}
