using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        while (true)
        {
            string resources = Console.ReadLine();
            if (resources == "stop")
            {
                break;
            }
            int quantity = int.Parse(Console.ReadLine());

            if (!dict.ContainsKey(resources))
            {
                dict.Add(resources, quantity);
            }
            else
            {
                dict[resources] += quantity;
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}