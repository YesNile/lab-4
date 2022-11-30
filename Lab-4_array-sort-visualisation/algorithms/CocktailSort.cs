using System;
using System.Threading;

namespace Lab_4_array_sort_visualisation.algorithms {
    public class CocktailSort : Algorithm<int> {
        /* Шейкер-сортировка */
        public CocktailSort() { }

        private void ShakerSort(int[] data) 
        {
            int left = 0,
                right = data.Length - 1;
            Console.WriteLine("Изначальные данные:");
            Logger.ShowData(data);
            Console.WriteLine("Сортировка: ");

            while (left < right) 
            {
                for (int i = left; i < right; i++) 
                {
                    Thread.Sleep(SortDelay);
                    if (data[i] > data[i + 1]) 
                    {
                        Swap(data, i, i + 1);
                        Logger.Log(data, i, i + 1, true);
                    }
                    else 
                    {
                        Logger.Log(data, i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--) 
                {
                    Thread.Sleep(SortDelay);
                    if (data[i - 1] > data[i]) 
                    {
                        Swap(data, i - 1, i);
                        Logger.Log(data, i - 1, i, true);
                    }
                    else 
                    {
                        Logger.Log(data, i - 1, i);
                    }
                }

                left++;
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированные данные:");
            Logger.ShowData(data);
        }

        /* Поменять элементы местами */
        static void Swap(int[] array, int i, int j) {
            (array[i], array[j]) = (array[j], array[i]);
        }

        public CocktailSort(int[] data, int delay) : base(data, delay) { }

        public override void Sort() {
            ShakerSort(Data);
        }
    }
}