using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> positiveNumbers = new List<int>();   

        foreach (int currentNumber in numbers)
        {
            if (currentNumber >= 0)
            {
                positiveNumbers.Add(currentNumber);
            }
        }

        if (positiveNumbers.Count > 0)
        {
            positiveNumbers.Reverse();
            Console.WriteLine(string.Join(" ", positiveNumbers));
        }
        else
        {
            Console.WriteLine("empty");
        }       
    }
}