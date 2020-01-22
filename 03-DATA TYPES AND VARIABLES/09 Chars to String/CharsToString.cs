using System;

class CharsToString
{
    static void Main()
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char thirdChar = char.Parse(Console.ReadLine());

        string result = "" + firstChar + secondChar + thirdChar;

        Console.WriteLine(result);

    }
}
