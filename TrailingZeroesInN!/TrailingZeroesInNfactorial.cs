using System;
using System.Numerics;

class TrailingZeroesInNfactorial
{
    /*Write a program that calculates with how many zeroes the factorial 
     * of a given number n has at its end. Your program should work well 
     * for very big numbers, e.g. n=100000.*/
    static void Main()
    {
        Console.Write("Please enter number n greater than 0: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 1)
        {
        int trail = n;
        int power = 1;
        int trailingZeros = 0;
        while (trail >= 1)
        {
            trail = n / (int) Math.Pow(5, power);
            trailingZeros += trail;
            power++;
        }
        Console.WriteLine("The !{0} have {1} trailing zeros.", n, trailingZeros);
        }
        else
        {
            Console.WriteLine("Invalid Input of number n!");
        }
    }
}


