using System;

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
            if (command.Contains("Start"))
            {
                if (input.StartsWith(split[1]))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            if (command.Contains("Lowercase"))
            {
                input = input.ToLower();
                Console.WriteLine(input);
            }
            if (command.Contains("FindIndex"))
            {
                Console.WriteLine(input.LastIndexOf(split[1]));
            }
            if (command.Contains("Remove"))
            {
                input = input.Remove(int.Parse(split[1]), int.Parse(split[2]));
                Console.WriteLine(input);
            }

            command = Console.ReadLine();
        }

    }
}