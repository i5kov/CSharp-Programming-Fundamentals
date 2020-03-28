using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string command = Console.ReadLine();

        while (command != "Done")
        {
            string[] split = command.Split();
            if (command.Contains("Change"))
            {
                input = input.Replace(split[1], split[2]);
                Console.WriteLine(input);
            }
            if (command.Contains("Includes"))
            {
                if (input.Contains(split[1]))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            if (command.Contains("End"))
            {
                if (input.EndsWith(split[1]))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            if (command.Contains("Uppercase"))
            {
                input = input.ToUpper();
                Console.WriteLine(input);
            }
            if (command.Contains("FindIndex"))
            {
                Console.WriteLine(input.IndexOf(split[1]));
            }
            if (command.Contains("Cut"))
            {
                int startIndex = int.Parse(split[1]);
                int endIndex = int.Parse(split[2]);
                input = input.Substring(startIndex, startIndex + endIndex);
                Console.WriteLine(input);
            }

            command = Console.ReadLine();
        }

    }
}