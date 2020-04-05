using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("!").ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] split = command.Split();
                string item = split[1];
                if (command.Contains("Urgent"))
                {
                    if (!list.Contains(item))
                    {
                        list.Insert(0, item);
                    }
                }
                else if (command.Contains("Unnecessary"))
                {
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                    }
                }
                else if (command.Contains("Correct"))
                {
                    string newItem = split[2];
                    if (list.Contains(item))
                    {
                        int index = list.IndexOf(item);
                        list.Remove(item);
                        list.Insert(index, newItem);
                    }
                }
                else if (command.Contains("Rearrange"))
                {
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                        list.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", list));
        }
    }
}
