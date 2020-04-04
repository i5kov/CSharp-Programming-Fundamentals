using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        PrintNxNMatrix(N);
    }

    private static void PrintNxNMatrix(int n)
    {
        for (int row = 0; row < n; row++)
        {
            Console.Write(n);
            for (int col = 1; col < n; col++)
            {
                Console.Write(" " + n);
            }
            Console.WriteLine();
        }
    }
}