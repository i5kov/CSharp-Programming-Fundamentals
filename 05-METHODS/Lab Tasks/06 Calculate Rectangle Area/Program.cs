using System;

class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine(GetRectangleArea(width, height));
    }

    private static int GetRectangleArea(int width, int height)
    {
        return width * height;
    }
}