using System;

namespace _01._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "For Azeroth")
            {
                string[] split = command.Split(" ");

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
                    var index = int.Parse(split[1]);
                    char letter = char.Parse(split[2]);

                    if (index < skill.Length && index >= 0)
                    {
                        char[] temp = skill.ToCharArray();
                        temp[index] = letter;
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
                    var substring = split[2];
                    var substringNew = split[3];

                    if (skill.Contains(substring))
                    {
                        skill = skill.Replace(substring, substringNew);
                        Console.WriteLine(skill);

                    }
                }
                else if (command.Contains("Target Remove"))
                {
                    var substring = split[2];
                    if (skill.Contains(substring))
                    {
                        var index = skill.IndexOf(substring);
                        skill = skill.Remove(index, substring.Length);
                        Console.WriteLine(skill);
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }

                command = Console.ReadLine();
            }
        }
    }
}