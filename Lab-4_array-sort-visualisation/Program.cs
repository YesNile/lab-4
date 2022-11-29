using System;
using Lab_4_array_sort_visualisation.algorithms;

namespace Lab_4_array_sort_visualisation {
    class Program {
        static void Main(string[] args) {
            try {
                Algorithm sort = new CocktailSort(new[] {1, 2, 5, 2, 5, 7, 98, 2, 4, 12}, 500);
                sort.Sort();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}