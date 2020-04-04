using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        List<double> resultList = new List<double>();

        for (int i = 0; i < numbers.Count / 2; i++)
        {
            resultList.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
        }

        if (numbers.Count % 2 != 0)
        {
            resultList.Add(numbers[numbers.Count / 2]);
        }

        Console.WriteLine(string.Join(" ", resultList));
    }
}