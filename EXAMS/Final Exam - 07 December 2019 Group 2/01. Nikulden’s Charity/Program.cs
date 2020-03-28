using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string command = Console.ReadLine();

        while (command != "Finish")
        {
            string[] split = command.Split();
            if (command.Contains("Replace"))
            {
                input = input.Replace(split[1], split[2]);
                Console.WriteLine(input);
            }
            if (command.Contains("Cut"))
            {
                int startIndex = int.Parse(split[1]);
                int endIndex = int.Parse(split[2]);
                if ( (startIndex >= 0 && startIndex <= input.Length) && (endIndex >= 0 && endIndex <= input.Length))
                {
                    string result = input.Remove(startIndex, (endIndex - startIndex) + 1);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid indexes!");
                }
            }
            if (command.Contains("Make"))
            {
                if (split[1] == "Upper")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
            }
            if (command.Contains("Check"))
            {
                if (input.Contains(split[1]))
                {
                    Console.WriteLine($"Message contains {split[1]}");
                }
                else
                {
                    Console.WriteLine($"Message doesn't contain {split[1]}");
                }
            }
            if (command.Contains("Sum"))
            {
                int startIndex = int.Parse(split[1]);
                int endIndex = int.Parse(split[2]);
                if ((startIndex >= 0 && startIndex <= input.Length) && (endIndex >= 0 && endIndex <= input.Length))
                {
                    String s = input.Substring(startIndex, (endIndex - startIndex) + 1);
                    int sum = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        sum += (int)s[i];
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine("Invalid indexes!");
                }
            }

            command = Console.ReadLine();
        }
    }
}