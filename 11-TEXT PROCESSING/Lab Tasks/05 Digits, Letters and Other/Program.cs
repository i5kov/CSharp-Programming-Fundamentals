using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string digits = null;
        string letters = null;
        string other = null;

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsDigit(input[i]))
            {
                digits += input[i];
            }
            else if (Char.IsLetter(input[i]))
            {
                letters += input[i];
            }
            else
            {
                other += input[i];
            }
        }

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(other);
    }
}