using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = Console.ReadLine().Split("!").ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] split = command.Split();
                if (command.Contains("Urgent"))
                {
                    if (!result.Contains(split[1]))
                    {
                        result.Insert(0, split[1]);
                    }
                } 
                if (command.Contains("Unnecessary"))
                {
                    if (result.Contains(split[1]))
                    {
                        result.Remove(split[1]);
                    }
                }
                if (command.Contains("Correct"))
                {
                    if (result.Contains(split[1]))
                    {
                        int index = result.IndexOf(split[1]);
                        result.Remove(split[1]);
                        result.Insert(index, split[2]);
                    }
                }
                if (command.Contains("Rearrange"))
                {
                    if (result.Contains(split[1]))
                    {
                        result.Remove(split[1]);
                        result.Add(split[1]);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
