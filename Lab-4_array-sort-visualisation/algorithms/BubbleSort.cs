using System;
using System.Threading;

namespace Lab_4_array_sort_visualisation.algorithms {
    public class BubbleSort : Algorithm<int> {
        private void Run(int[] array) {
            Console.WriteLine("Изначальные данные:");
            Logger.ShowData(array);
            Console.WriteLine("Сортировка: ");
            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array.Length - 1; j++) {
                    Thread.Sleep(SortDelay);
                    if (array[j] > array[j + 1]) {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                        Logger.Log(array, j, j + 1, true);
                    }
                    else {
                        Logger.Log(array, j, j + 1);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированные данные:");
            Logger.ShowData(Data);
        }

        public BubbleSort(int[] data, int delay) : base(data, delay) { }
        public BubbleSort() { }

        public override void Sort() {
            Run(Data);
        }
    }
}