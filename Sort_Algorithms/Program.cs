using System;

namespace Sort_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4,7,2,5,1};
            double[] nums2 = { 0.23, 0.53, 0.33, 0.75, 0.43, 0.73 };
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
            //quick_.quick_sort(nums);
            quick quick = new();
            //quick.quicks(nums);
            Merge_Sort merge_ = new();
            //merge_.MergeSort(nums);

            //MergeExaplain
            //MergeExaplain.MergeE(nums);

            //heap sort
            //HeapSort.HeapSor(nums);
            BucketSort.BucketSor(nums2);
            /*foreach (int item in nums2)
            {
                Console.WriteLine(item);
            }*/


        }
    }
}
