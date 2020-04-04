using System;

class RandomizeWords
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] words = input.Split();

        Random random = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int index = random.Next(0, words.Length - 1);
            string temp = words[index];
            words[index] = words[i];
            words[i] = temp;
        }

        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
}