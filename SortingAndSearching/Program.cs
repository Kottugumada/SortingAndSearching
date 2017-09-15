using System;

namespace SortingAndSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] unsorted = new int[5] { 5, 1, 4, 2, 8 };
            int[] sorted = bubbleSort.sortArray(unsorted);
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.WriteLine(sorted[i] + ",");
            }
            Console.Read();
        }
    }
}
