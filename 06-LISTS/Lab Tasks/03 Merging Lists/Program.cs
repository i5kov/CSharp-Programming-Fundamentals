using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

        int longestList = Math.Max(firstList.Count, secondList.Count);
        List<int> resultList = new List<int>();

        for (int i = 0; i < longestList; i++)
        {
            if (i < firstList.Count)
            {
                resultList.Add(firstList[i]);
            }
            if (i < secondList.Count)
            {
                resultList.Add(secondList[i]);
            }
        }
        Console.WriteLine(string.Join(" ", resultList));
    }
}