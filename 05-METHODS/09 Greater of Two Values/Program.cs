using System;

class Program
{
    static void Main()
    {
        string valType = Console.ReadLine();
        GetMaxValue(valType);
    }

    private static int GetMaxInt(int firstNumber, int secondNumber)
    {
        return firstNumber > secondNumber ? firstNumber : secondNumber;
    }

    private static char GetMaxChar(char firstChar, char secondChar)
    {
        return firstChar > secondChar ? firstChar : secondChar;
    }

    private static string GetMaxString(string firstString, string secondString)
    {
        return firstString.CompareTo(secondString) >= 0 ? firstString : secondString;
    }

    private static void GetMaxValue(string valueType)
    {
        switch (valueType)
        {
            case "int":
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int greaterIntValue = GetMaxInt(firstNumber, secondNumber);
                Console.WriteLine(greaterIntValue);
                break;
            case "char":
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char greaterCharValue = GetMaxChar(firstChar, secondChar);
                Console.WriteLine(greaterCharValue);
                break;
            case "string":
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string greaterStringValue = GetMaxString(firstString, secondString);
                Console.WriteLine(greaterStringValue);
                break;
        }
    }
}