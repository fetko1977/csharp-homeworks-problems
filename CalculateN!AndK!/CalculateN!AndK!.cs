using System;
using System.Numerics;

class Program
{
    /*Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.*/
    static void Main()
    {
        Console.WriteLine("Please enter 2 numbers - K and N. K should be smaller then N, but bigger than 1 and N should be smaller than 100 -");
        Console.Write("Number K: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Number N: ");
        int N = int.Parse(Console.ReadLine());
        BigInteger factorialK = 1;
        BigInteger factorialN = 1;
        if (1 < K && K < N && N < 100)
        {
            for (int number = 1; number <= N; number++)
            {
                if (number <= K)
                {
                    factorialK *= number;
                } 
                factorialN *= number;
            }
            Console.WriteLine("The division of !{0} with !{1} is {2}.", N, K, factorialN / factorialK);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}

