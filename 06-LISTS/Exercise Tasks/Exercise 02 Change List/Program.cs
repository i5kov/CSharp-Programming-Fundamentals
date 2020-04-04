using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            string[] command = Console.ReadLine().Split();
            if (command[0] == "end")
            {
                break;
            }
            else
            {
                if (command.Length > 2)
                {
                    int item = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, item);
                }
                else
                {
                    int itemForDeletion = int.Parse(command[1]);
                    numbers.RemoveAll(x => x == itemForDeletion);
                }
            }            
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}