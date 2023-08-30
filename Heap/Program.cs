using System;
using System.Collections.Generic;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int[] arr = { 2, 43, 5, 67, 8, 9, 0, 66 };
            MaxHeap maxHeapInstance = new MaxHeap(arr);
            int a = maxHeapInstance.peek();
            List<int> b = maxHeapInstance.print();
            foreach (int item in b)
            {
                Console.WriteLine(item);
            }*/
            List<int> l = new List<int> { 1, 4, 65, 787, 9, 4 };
            FindKvalue f = new FindKvalue(l);
            List<int> a = f.findkMax(3);
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
