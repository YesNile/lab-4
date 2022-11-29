using System;
using System.Text;

namespace Lab_4_array_sort_visualisation.utils {
    public class Logger {

        public void Log(int[] data, int firstValue, int secondValue, bool swap = false) {
            Console.WriteLine();
            Console.Write("[ ");
            for (int i = 0; i < data.Length; i++) {
                if (i == firstValue || i == secondValue) {
                    if (swap) {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    if (data.Length - 1 == i) {
                        Console.Write(data[i]);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else {
                        Console.Write(data[i]);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                }
                else {
                    if (data.Length - 1 == i) {
                        Console.Write($"{data[i]} ");
                    }
                    else {
                        Console.Write($"{data[i]} ");
                    }
                }
            }

            Console.Write("]");
            if (swap) {
                Console.Write(
                    $" - меняем элемент {data[firstValue]} под индексом {firstValue} и элемент {data[secondValue]} под индексом {secondValue}");
            }

            Console.WriteLine();
        }

        public void ShowData(int[] data) {
            Console.WriteLine();
            StringBuilder sb = new StringBuilder("[ ");
            sb.Append(string.Join(" ", data)).Append(" ]");
            Console.Write(sb.ToString());
            Console.WriteLine();
        }
    }
}