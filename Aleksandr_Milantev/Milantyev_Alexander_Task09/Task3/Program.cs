using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static bool WordIsNotInDictionary(string word, Dictionary<string, int> dict)
        {
            foreach (var pair in dict)
            {
                if (word.Equals(pair.Key, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }
        
        static string[] GetWords(string text)
        {
            List<char> separators = new List<char>();
            foreach (char symb in text)
            {
                if (char.IsPunctuation(symb) || char.IsSeparator(symb))
                {
                    separators.Add(symb);
                }
            }
            var words = text.Split(separators.ToArray());
            return words;
        }

        static Dictionary<string, int> GetWordCountDictionary(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!String.IsNullOrWhiteSpace(word))
                {
                    int count = 0;
                    for (int i = 0; i < words.Count(); i++)
                    {
                        if (words[i].Equals(word, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                    if (WordIsNotInDictionary(word, dict))
                    {
                        dict.Add(word, count);
                    }
                }
            }
            return dict;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var words = GetWords(text);
            var dict = GetWordCountDictionary(words);
            foreach (var pair in dict)
            {
                Console.WriteLine("\n{0}-{1}", pair.Key, pair.Value);
            }
            Console.ReadKey();
        }
    }
}
