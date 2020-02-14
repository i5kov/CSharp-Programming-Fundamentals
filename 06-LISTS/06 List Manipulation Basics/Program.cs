using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string[] command = Console.ReadLine().ToLower().Split();

        while (command[0] != "end")
        {
            int item = int.Parse(command[1]);
            switch (command[0])
            {
                case "add":
                    numbers.Add(item); 
                    break;
                case "remove":
                    numbers.Remove(item); 
                    break;
                case "removeat":
                    numbers.RemoveAt(item); 
                    break;
                case "insert":
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                    break;
            }
            command = Console.ReadLine().ToLower().Split();           
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}