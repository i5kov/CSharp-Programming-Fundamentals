using System;

namespace _01._String_Manipulator___Group_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] split = command.Split();
                if (command.Contains("Translate"))
                {
                    char c = char.Parse(split[1]);
                    char replacement = char.Parse(split[2]);
                    input = input.Replace(c, replacement);
                    Console.WriteLine(input);
                }
                else if (command.Contains("Includes"))
                {
                    string s = split[1];
                    if (input.Contains(s))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command.Contains("Start"))
                {
                    string s = split[1];
                    if (input.StartsWith(s))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command.Contains("Lowercase"))
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (command.Contains("FindIndex"))
                {
                    char c = char.Parse(split[1]);
                    int index = input.LastIndexOf(c);
                    Console.WriteLine(index);
                }
                else if (command.Contains("Remove"))
                {
                    int startIndex = int.Parse(split[1]);
                    int count = int.Parse(split[2]);
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }

        }
    }
}
