using System;

namespace Sort_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4,7,2,5,1};
            double[] nums2 = { 0.23, 0.53, 0.33, 0.75, 0.43, 0.73 };
            int[] nums3 = { 4, 3, 5, 6, 1, 3, 4, 5 };
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
            //BucketSort.BucketSor(nums2);


            CountingSort.CountSort(nums3);

            foreach (int item in nums3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------couting sort version two---------------");
            ProductUserForCountngSort[] productUserForCountngSorts = new ProductUserForCountngSort[] {
                    new ProductUserForCountngSort(3,"B"),
                    new ProductUserForCountngSort(2,"C"),
                    new ProductUserForCountngSort(2,"A"),
                    new ProductUserForCountngSort(4,"D")};

            //CoutingSortVersion2.CountingSortStable(productUserForCountngSorts);
            CountingSortSolution3.CountingSortSolution(productUserForCountngSorts);
            foreach (var item in productUserForCountngSorts)
            {
                Console.WriteLine($"{item.Price} -- {item.Name}");
            }
            int[] nums4 = new int[]{
                2021003,
                2021001,
                2021004,
                2021002,
                2021005
            };

            Console.WriteLine("-----------radix sort version---------------");
            Radix.RadixSort(nums4);
            foreach (var item in nums4)
            {
                Console.WriteLine(item);
            }

        }
    }
}
