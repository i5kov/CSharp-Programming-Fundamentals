using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        SortedDictionary<int, int> dict = new SortedDictionary<int, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (dict.ContainsKey(numbers[i]))
            {
                dict[numbers[i]]++;
            } 
            else
            {
                dict.Add(numbers[i], 1);
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}