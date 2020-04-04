using System;

class Program
{
    static void Main()
    {

        int[] array = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < 2; i++)
        {
            int lastEl = array[array.Length - 1];
            for (int j = array.Length - 1; j >= 1; j--)
            {
                array[j] = array[j - 1];
            }
            array[0] = lastEl;
        }

        Console.WriteLine(string.Join(" ", array));

    }
}