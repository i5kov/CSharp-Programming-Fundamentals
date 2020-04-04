using System;

class Program
{
    static void Main(string[] args)
    {   

        while (true)
        {
            string word = Console.ReadLine();
            string reverseWord = null;

            if (word == "end")
            {
                break;
            }

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }

            Console.WriteLine($"{word} = {reverseWord}");
        }
    }
}