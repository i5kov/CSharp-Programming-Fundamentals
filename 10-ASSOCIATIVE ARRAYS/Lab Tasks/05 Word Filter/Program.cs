using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split();

        words
            .Where(x => x.Length % 2 == 0)
            .ToList()
            .ForEach(x => Console.WriteLine(x));
    }
}