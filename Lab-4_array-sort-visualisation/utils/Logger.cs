using System;
using System.Text;

namespace Lab_4_array_sort_visualisation.utils {
    public class Logger {
        private readonly int[] _data;

        public Logger(int[] data) {
            this._data = data;
        }

        public void Log(int firstValue, int secondValue, bool swap = false) {
            Console.WriteLine();
            Console.Write("[ ");
            for (int i = 0; i < _data.Length; i++) {
                if (i == firstValue || i == secondValue) {
                    if (swap) {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    if (_data.Length - 1 == i) {
                        Console.Write(_data[i]);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else {
                        Console.Write(_data[i]);
                        Console.ResetColor();
                        Console.Write(", ");
                    }
                }
                else {
                    if (_data.Length - 1 == i) {
                        Console.Write(_data[i] + " ");
                    }
                    else {
                        Console.Write(_data[i] + ", ");
                    }
                }
            }
            Console.Write("]");
            if (swap) {
                Console.Write(
                    $" - меняем элемент {_data[firstValue]} под индексом {firstValue} и элемент {_data[secondValue]} под индексом {secondValue}");
            }

            Console.WriteLine();
        }

        public void ShowData() {
            Console.WriteLine();
            StringBuilder sb = new StringBuilder("[ ");
            sb.Append(string.Join(", ", _data)).Append(" ]");
            // Console.Write("[ ");
            // for (int i = 0; i < data.Length; i++)
            // {
            //     if (data.Length - 1 == i)
            //     {
            //         Console.Write(data[i] + " ");
            //     }
            //     else
            //     {
            //         Console.Write(data[i] + ", ");
            //     }
            // }
            // Console.Write("]");
            Console.Write(sb.ToString());
            Console.WriteLine();
        }
    }
}