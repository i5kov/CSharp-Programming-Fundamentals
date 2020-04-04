using System;

namespace _01._String_Manipulator___Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] split = command.Split();
                if (command.Contains("Change"))
                {
                    char c = char.Parse(split[1]);
                    char replacement = char.Parse(split[2]);
                    message = message.Replace(c, replacement);
                    Console.WriteLine(message);
                }
                else if (command.Contains("Includes"))
                {
                    string s = split[1];
                    if (message.Contains(s))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command.Contains("End"))
                {
                    string s = split[1];
                    if (message.EndsWith(s))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command.Contains("Uppercase"))
                {
                    message = message.ToUpper();
                    Console.WriteLine(message);
                }
                else if (command.Contains("FindIndex"))
                {
                    char c = char.Parse(split[1]);
                    int firstIndex = message.IndexOf(c);
                    Console.WriteLine(firstIndex);
                }
                else if (command.Contains("Cut"))
                {
                    int startIndex = int.Parse(split[1]);
                    int length = int.Parse(split[2]);

                    string removed = message.Substring(startIndex, length);
                    Console.WriteLine(removed);
                }
                command = Console.ReadLine();
            }
        }
    }
}
