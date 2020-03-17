﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine().ToLower();
        string secondWord = Console.ReadLine();

        while (secondWord.Contains(word))
        {
            int startIndex = secondWord.IndexOf(word);
            secondWord = secondWord.Remove(startIndex, word.Length);
        }

        Console.WriteLine(secondWord);
    }
}