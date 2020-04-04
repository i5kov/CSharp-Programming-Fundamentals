using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        Dictionary<string, List<string>> wordAndSynonyms = new Dictionary<string, List<string>>();

        for (int i = 0; i < lines; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (!wordAndSynonyms.ContainsKey(word))
            {
                wordAndSynonyms.Add(word, new List<string>());
            }
            wordAndSynonyms[word].Add(synonym);
        }

        foreach (var item in wordAndSynonyms)
        {
            Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
        }
    }
}