using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int count = 0;

            while (command != "End")
            {
                int index = int.Parse(command);

                if (index >= 0 && index < arr.Length)
                {
                    count++;
                    int element = arr[index];
                    arr[index] = -1;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] != -1)
                        {
                            if (arr[i] > element)
                            {
                                arr[i] -= element;
                            }
                            else
                            {
                                arr[i] += element;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", arr)}");
        }
    }
}
