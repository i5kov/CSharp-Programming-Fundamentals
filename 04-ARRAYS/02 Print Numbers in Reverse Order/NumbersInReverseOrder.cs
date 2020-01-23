using System;

class NumbersInReverseOrder
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        int[] arr = new int[lines];

        for (int i = 0; i < lines; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}