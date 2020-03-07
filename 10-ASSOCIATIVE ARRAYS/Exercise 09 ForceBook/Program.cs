using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var dict = new Dictionary<string, List<string>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Lumpawaroo")
            {
                break;
            }

            if (input.Contains("|"))
            {
                string[] array = input.Split(" | ").ToArray();
                string firstCommand = array[0];
                string secondCommand = array[1];

                if (!dict.ContainsKey(firstCommand))
                {
                    dict[firstCommand] = new List<string>();
                }
                if (!dict[firstCommand].Contains(secondCommand))
                {
                    dict[firstCommand].Add(secondCommand);
                }

            }
            else
            {
                string[] array = input.Split(" -> ").ToArray();
                string firstCommand = array[0];
                string secondCommand = array[1];

                foreach (var kpv in dict)
                {
                    if (kpv.Value.Contains(firstCommand))
                    {
                        kpv.Value.Remove(firstCommand);
                    }
                }

                if (!dict.ContainsKey(secondCommand))
                {
                    dict[secondCommand] = new List<string>();
                }
                dict[secondCommand].Add(firstCommand);

                Console.WriteLine($"{firstCommand} joins the {secondCommand} side!");
            }

        }
        dict = dict
            .Where(x => x.Value.Count > 0)
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kpv in dict)
        {
            Console.WriteLine($"Side: {kpv.Key}, Members: {kpv.Value.Count}");
            foreach (var item in kpv.Value.OrderBy(x => x))
            {
                Console.WriteLine($"! {item}");
            }
        }
    }
}
