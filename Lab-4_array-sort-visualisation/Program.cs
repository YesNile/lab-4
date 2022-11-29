using System;
using System.Collections.Generic;
using System.IO;
using AlgorhythmsLab3.Tester;
using AlgorythmsLab3.Testing.Tester;
using Lab_4_array_sort_visualisation.algorithms;
using Lab_4_array_sort_visualisation.menu;
using Lab_4_array_sort_visualisation.menu.menus;

namespace Lab_4_array_sort_visualisation {
    class Program {
        static void Main(string[] args) {
            // Menu menu = new MainMenu();                  //Запуск меню с работой в программе
            // menu.Start();
           // TestTextSort(x=>ABCSort.Sort(x),"ABCSort",1);             //тест ABCSort слов
            TestTextSort(x=>ShakerSort.Sort(x),"ShakerSort",1);                 //тест ShakerSort слов
        }
        private static void TestTextSort(Func<List<string>, ICollection<string>> func, string name, int iterCount)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            var allText = File.ReadAllText(Directory.GetCurrentDirectory() + "\\..\\..\\testText.txt").Split(' ');
            for (int i = 1; i <= 10_000; i += 1)
            {
                var testText = CopyTo(allText, i);
                
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke(testText), iterCount, name);
                tester2.Test(() => func.Invoke(testText), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        private static List<string> CopyTo(string[] array, int index)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < index; i++)
            {
                list.Add(array[i]);
            }

            return list;
        }
    }
}