using System;
using System.Linq;

class EqualSum
{
    static void Main()
    {
        int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (numArray.Length == 1)
        {
            Console.WriteLine("0"); 
            return;
        }

        int leftSum = 0;
        int rightSum = 0;
        bool found = false;

        for (int pos = 0; pos < numArray.Length; pos++) 
        {
            
            for (int L = 0; L < pos; L++)
            {
                leftSum += numArray[L];
            }
            
            for (int R = pos + 1; R < numArray.Length; R++)
            {
                rightSum += numArray[R];
            }

            
            if (leftSum == rightSum)
            {
                Console.WriteLine(pos);
                found = true;
            }
            else
            {
                leftSum = 0;
                rightSum = 0;
            }
        }

        if (found == false)
        {
            Console.WriteLine("no");
        }
    }
}