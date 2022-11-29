using System;
using Lab_4_array_sort_visualisation.algorithms;

namespace Lab_4_array_sort_visualisation {
    class Program {
        static void Main(string[] args) {
            try {
                BubbleSort sort = new BubbleSort(new[] {1, 2, 5, 2, 5, 7, 98, 2, 4, 12}, 1000);
                sort.Sort();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}