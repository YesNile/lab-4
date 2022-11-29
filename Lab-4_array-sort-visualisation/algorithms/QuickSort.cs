using System;
using System.Threading;

namespace Lab_4_array_sort_visualisation.algorithms {
    public class QuickSort : Algorithm {
        private void swap(int[] arr, int i, int j) {
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }

        private int partition(int[] arr, int low, int high) {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++) {
                Thread.Sleep(SortDelay);
                if (arr[j] < pivot) {
                    i++;
                    swap(arr, i, j);
                    if (i != j) {
                        Logger.Log(Data, i, j, true);
                    }
                    else {
                        Logger.Log(Data, i, j);
                    }
                }
                else {
                    Logger.Log(Data, i, j);
                }
            }

            swap(arr, i + 1, high);
            if (i + 1 != high) {
                Logger.Log(Data, i + 1, high, true);
            }
            else {
                Logger.Log(Data, i + 1, high);
            }

            return i + 1;
        }

        private void Quick_Sort(int[] arr, int low, int high) {
            if (low < high) {
                int pi = partition(arr, low, high);

                Quick_Sort(arr, low, pi - 1);
                Quick_Sort(arr, pi + 1, high);
            }
        }

        public QuickSort(int[] data, int delay) : base(data, delay) { }

        public override void Sort() {
            Console.WriteLine("Изначальные данные:");
            Logger.ShowData(Data);
            Console.WriteLine("Сортировка: ");
            Quick_Sort(Data, 0, Data.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Отсортированные данные:");
            Logger.ShowData(Data);
        }
    }
}