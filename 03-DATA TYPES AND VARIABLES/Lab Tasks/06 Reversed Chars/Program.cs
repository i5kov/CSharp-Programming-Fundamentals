using System;

class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string third = Console.ReadLine();
        string result = string.Format($"{first} {second} {third}");

        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
    }
}