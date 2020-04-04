using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().ToLower().Split();
        Dictionary<string, int> countWords = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (!countWords.ContainsKey(words[i]))
            {
                countWords.Add(words[i], 1);
            }
            else
            {
                countWords[words[i]]++;
            }
        }

        foreach (var item in countWords)
        {
            if (item.Value % 2 != 0)
            {
                Console.Write(item.Key + " ");
            }
        }
    }
}