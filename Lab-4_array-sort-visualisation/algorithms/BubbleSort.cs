using System;
using System.Threading;
using System.Threading.Channels;

namespace Lab_4_array_sort_visualisation.algorithms {
    public class BubbleSort : Algorithm {
        private void Run(int[] array) {
            Console.WriteLine("Изначальные данные:");
            Logger.ShowData();
            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array.Length - 1; j++) {
                    Thread.Sleep(SortDelay);//TODO поменять на задаваемые данные
                    if (array[j] > array[j + 1]) {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                        Logger.Log(j, j + 1, true);
                    }
                    else {
                        Logger.Log(j, j + 1);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированные данные:");
            Logger.ShowData();
        }

        public BubbleSort(int[] data, int delay) : base(data, delay) { }

        public override void Sort() {
            Run(Data);
        }
    }
}