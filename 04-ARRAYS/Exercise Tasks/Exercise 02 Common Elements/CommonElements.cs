using System;
using System.Linq;

class CommonElements
{
    static void Main(string[] args)
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        string[] firstArr = firstInput.Split(' ');
        string[] secondArr = secondInput.Split(' ');

        for (int i = 0; i < secondArr.Length; i++)
        {
            for (int j = 0; j < firstArr.Length; j++)
            {
                if (secondArr[i] == firstArr[j])
                {
                    Console.Write(secondArr[i] + " ");
                }
            }
        }
    }
}