using System;

class Train
{
    static void Main(string[] args)
    {
        int wagons = int.Parse(Console.ReadLine());
        int[] train = new int[wagons];
        int totalPeople = 0;

        for (int i = 0; i < wagons; i++)
        {
            train[i] = int.Parse(Console.ReadLine());
            totalPeople += train[i];
        }

        for (int i = 0; i < train.Length; i++)
        {
            Console.Write(train[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(totalPeople);
    }
}