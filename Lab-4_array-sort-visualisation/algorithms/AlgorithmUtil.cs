using System.Collections.Generic;

namespace Lab_4_array_sort_visualisation.algorithms
{
    public class AlgorithmUtil
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
    }
}