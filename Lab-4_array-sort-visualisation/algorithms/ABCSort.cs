using System;
using System.Collections.Generic;
using System.Threading;

namespace Lab_4_array_sort_visualisation.algorithms
{
    public class ABCSort : Algorithm<string>
    {
        private ICollection<string> Sorting(ICollection<string> words, int rank = 0)
        {
            if (words.Count > 1)
            {
                Console.WriteLine($"Сравнение слов по символу на позиции {rank}\n");
                Thread.Sleep(SortDelay);
                Dictionary<char, List<string>> squares = new Dictionary<char, List<string>> {{'@', new List<string>()}};
                foreach (var word in words)
                {
                    Console.WriteLine($"Сравнение позиции {rank} и длину слова {word}");
                    Thread.Sleep(SortDelay);
                    if (rank < word.Length)
                    {
                        if (squares.ContainsKey(word[rank]))
                        {
                            squares[word[rank]].Add(word);
                        }
                        else
                        {
                            squares.Add(word[rank], new List<string>() {word});
                        }

                        Console.WriteLine($"\tДобавление слова \"{word}\" в группу [ {word[rank]} ]\n");
                        Thread.Sleep(SortDelay);
                    }
                    else
                    {
                        Console.WriteLine($"Добавление слова \"{word}\" в дефолтную группу [ @ ]\n");
                        Thread.Sleep(SortDelay);
                        squares['@'].Add(word);
                    }
                }

                if (squares['@'].Count == words.Count)
                {
                    Console.WriteLine(
                        $"Прошли все символы всех слов, поэтому добавляем отсортированные значение в результирующий список\n");
                    Thread.Sleep(SortDelay);
                    return words;
                }

                List<string> result = new List<string>();
                for (char i = '@'; i <= 'z'; i++)
                {
                    if (squares.ContainsKey(i))
                    {
                        foreach (var word in Sorting(squares[i], rank + 1))
                        {
                            result.Add(word);
                        }
                    }
                }

                return result;
            }

            return words;
        }

        public override void Sort()
        {
            Sorting(Data);
        }
    }
}