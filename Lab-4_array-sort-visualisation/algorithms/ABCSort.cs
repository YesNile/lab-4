using System.Collections.Generic;

namespace Lab_4_array_sort_visualisation.algorithms
{
    public class ABCSort
    {
        public static Dictionary<string, int> Count(ICollection<string> text)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var word in text)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            return dictionary;
        }

        public static ICollection<string> Sort(ICollection<string> words, int rank = 0)
        {
            if (words.Count > 1)
            {
                Dictionary<char, List<string>> squares = new Dictionary<char, List<string>> {{'@', new List<string>()}};
                foreach (var word in words)
                {
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
                    }
                    else
                    {
                        squares['@'].Add(word);
                    }
                }

                if (squares['@'].Count == words.Count)
                {
                    return words;
                }

                List<string> result = new List<string>();
                for (char i = '@'; i <= 'z'; i++)
                {
                    if (squares.ContainsKey(i))
                    {
                        foreach (var word in Sort(squares[i], rank + 1))
                        {
                            result.Add(word);
                        }
                    }
                }

                return result;
            }

            return words;
        }
    }
}