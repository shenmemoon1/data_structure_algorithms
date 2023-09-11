using System;

namespace Sort_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4,3,2,5,1};
            //SELECT SORT
            Selection_Sort selection_ = new();
            //selection_.selectionSort(nums);

            //Bubble Sort
            Bubble_Sort bubble_ = new();
            //bubble_.bubble_sort(nums);

            //Insertion Sort
            Insertion_Sort insertion_ = new();
            //insertion_.insertionSort(nums);

            Quick_Sort quick_ = new();
            quick_.quick_sort(nums);
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
