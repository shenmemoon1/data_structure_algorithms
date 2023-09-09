using System;

namespace Sort_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 3, 1, 5, 2 };
            //SELECT SORT
            Selection_Sort selection_ = new();
            //selection_.selectionSort(nums);

            //Bubble Sort
            Bubble_Sort bubble_ = new();
            bubble_.bubble_sort(nums);
        }
    }
}
