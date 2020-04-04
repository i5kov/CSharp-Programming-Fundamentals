using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            string[] splitInput = input.Split(" -> ");
            string company = splitInput[0];
            string employeeId = splitInput[1];

            if (!companies.ContainsKey(company))
            {
                companies.Add(company, new List<string>());
            }
            if (!companies[company].Contains(employeeId))
            {
                companies[company].Add(employeeId);
            }
        }

        foreach (var item in companies.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}");
            foreach (var id in item.Value)
            {
                Console.WriteLine($"-- {id}");
            }
        }
    }
}