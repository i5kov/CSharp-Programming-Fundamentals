using System;


class Program
{
    static void Main(string[] args)
    {
        string skill = Console.ReadLine();
        string command = Console.ReadLine();

        while (command != "For Azeroth")
        {
            string[] split = command.Split();
            if (command.Contains("GladiatorStance"))
            {
                skill = skill.ToUpper();
                Console.WriteLine(skill);
            }
            else if (command.Contains("DefensiveStance"))
            {
                skill = skill.ToLower();
                Console.WriteLine(skill);
            }
            else if (command.Contains("Dispel"))
            {
                int index = int.Parse(split[1]);
                char c = char.Parse(split[2]);
                if (index >= 0 && index <= skill.Length)
                {
                    char[] temp = skill.ToCharArray();
                    temp[index] = c;

                    skill = new string(temp);

                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine("Dispel too weak.");
                }
            }
            else if (command.Contains("Target Change"))
            {
                skill = skill.Replace(split[2], split[3]);
                Console.WriteLine(skill);
            }
            else if (command.Contains("Target Remove"))
            {
                skill = skill.Remove(skill.IndexOf(split[2]), split[2].Length);
                Console.WriteLine(skill);
            }
            else
            {
                Console.WriteLine("Command doesn't exist!");
            }
            command = Console.ReadLine();
        }
    }
}