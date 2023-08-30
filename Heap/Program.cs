using System;
using System.Collections.Generic;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 2, 43, 5, 67, 8, 9, 0, 66 };
            MaxHeap maxHeapInstance = new MaxHeap(arr);
            int a = maxHeapInstance.peek();
            List<int> b = maxHeapInstance.print();
            foreach (int item in b)
            {
                Console.WriteLine(item);
            }

            //using travel
            Console.WriteLine("----------------------find k array traveral------------------------------");
            List<int> l = new List<int> { 1, 4, 65, 787, 9, 4 };
            FindKvalue f = new FindKvalue(l);
            List<int> c = f.findkMax(3);
            foreach (int item in c)
            {
                Console.WriteLine(item);
            }

            //using heap
            Console.WriteLine("----------------------find k heap------------------------------");
            FindKValueHeap findKValueHeap = new FindKValueHeap();
             
            List<int> d = findKValueHeap.find(3);
            foreach (int item in d)
            {
                Console.WriteLine(item);
            }

        }
    }
}
