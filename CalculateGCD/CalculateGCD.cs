using System;

class CalculateGCD
{
    /*Write a program that calculates the greatest common divisor 
     * (GCD) of given two integers a and b. 
     * Use the Euclidean algorithm (find it in Internet).*/
    static void Main()
    {
        Console.WriteLine("Please enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int orgA = a;
        int orgB = b;
        int max = Math.Max(a, b);
        int remain = 1;
        int maxDivider;
        if (a == 0 && b != 0)
        {
            maxDivider = b;
        }
        else if (a != 0 && b == 0)
        {
            maxDivider = a;
        }
        else if (a == max)
        {
            while (remain != 0)
            {
                remain = a % b;
                a = b;
                b = remain;
            }
            maxDivider = a;
        }
        else
        {
            while (remain != 0)
            {
                remain = b % a;
                b = a;
                a = remain;
            }
            maxDivider = b;
        }
        Console.WriteLine("The GCD of {0} and {1} is {2}: ", orgA, orgB, maxDivider);
    }
}

