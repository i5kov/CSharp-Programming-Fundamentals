using System;


class MultiplicationTable2
{
    static void Main()
    {
        int theInteger = int.Parse(Console.ReadLine());
        int times = int.Parse(Console.ReadLine());

        if (times > 10)
        {
            Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
        }
        else
        {
            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
            }
        }
    }
}