using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] split = command.Split(">>>");
                if (command.Contains("Contains"))
                {
                    if (input.Contains(split[1]))
                    {
                        Console.WriteLine($"{input} contains {split[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command.Contains("Flip"))
                {
                    string upperOrLower = split[1];
                    int startIndex = int.Parse(split[2]);
                    int endIndex = int.Parse(split[3]);

                    string result;

                    if (upperOrLower == "Upper")
                    {
                        result = input.ToUpper().Substring(startIndex, (endIndex - startIndex));
                    }
                    else
                    {
                        result = input.ToLower().Substring(startIndex, (endIndex - startIndex));
                    }
                    input = input.Replace(input.Substring(startIndex, (endIndex - startIndex)), result);
                    Console.WriteLine(input);
                }
                else if (command.Contains("Slice"))
                {
                    int startIndex = int.Parse(split[1]);
                    int endIndex = int.Parse(split[2]);

                    input = input.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}