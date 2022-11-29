using System;
using System.Linq;
using System.Text.RegularExpressions;
using Lab_4_array_sort_visualisation.menu.utils;

namespace Lab_4_array_sort_visualisation.menu.menus {
    public class ABCSortMenu : MenuItem {
        public ABCSortMenu(bool isSelected = false) : base(title: "ABC Сортировка текста", isSelected)
        {
        }

        public override void Execute()
        {
            do
            {
                ConsoleUtil.ClearScreen();
                Console.WriteLine($"[ {Title.ToUpper()} ]\n");
                Console.CursorVisible = true;
                
                Console.WriteLine("Введите текст, слова которого должны быть отсортированы: ");
                string inputText = Console.ReadLine();
                if (string.IsNullOrEmpty(inputText))
                {
                    Console.WriteLine("Введенная строка пуста!");
                }
                else if (new Regex("[0-9]", RegexOptions.Compiled | RegexOptions.IgnoreCase)
                             .Matches(inputText).Count > 0)
                {
                    Console.WriteLine("Строка содержит числовые значения!");
                }
                else
                {
                    var inputListWord = inputText.Trim().Split(new []{' ', ',', '.', '(', ')'}).Where(x => x != "").ToList();
                    var result = algorithms.ABCSort.Sort(inputListWord).ToList();
                    for (int i = 0; i < result.Count; i++)
                    {
                        Console.WriteLine($"{i}) {result[i]} ");
                    }

                    var wordCount = algorithms.ABCSort.Count(result);
                    Console.WriteLine("\nПодсчет количества слова в тексте:\n");
                    foreach (var word in wordCount)
                    {
                        Console.WriteLine($"{word.Key} [ {word.Value} ]");
                    }
                }
                
                Console.CursorVisible = false;
            } while (ConsoleUtil.Continue());
        }
    }
}