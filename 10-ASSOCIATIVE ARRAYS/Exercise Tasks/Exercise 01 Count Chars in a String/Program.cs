using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                if (!dict.ContainsKey(input[i][j]))
                {
                    dict.Add(input[i][j], 1);
                }
                else
                {
                    dict[input[i][j]]++;
                }
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}