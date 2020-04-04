using System;

class PokeMon
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        double nDividedByTwo = n / 2.0;

        int cnt = 0;
        while (n >= m)
        {
            if (n == nDividedByTwo)
            {
                if (y != 0)
                {
                    n = n / y;
                }
                if (n >= m)
                {
                    n = n - m;
                    cnt++;
                }
            }
            else
            {
                n = n - m;
                cnt++;
            }

        }
        Console.WriteLine(n);
        Console.WriteLine(cnt);
    }
}

