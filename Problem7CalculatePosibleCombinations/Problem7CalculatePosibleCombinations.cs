using System;
using System.Numerics;

class Problem7CalculatePosibleCombinations
{
    /*In combinatorics, the number of ways to choose k different 
     * members out of a group of n different elements (also known as the number of combinations) 
     * is calculated by the following formula:
     * For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
     * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
     * Try to use only two loops.
     */
    static void Main()
    {
        Console.WriteLine("Please enter number K bigger than 0 and number N bigger than K and smaller than 100 - ");
        Console.Write("Please enter K:");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Please enter N:");
        int N = int.Parse(Console.ReadLine());
        BigInteger factorialK = 1;
        BigInteger factorialN = 1;
        BigInteger factorialKandN = 1;
        int multiKandN = N - K;
        BigInteger result;
        if (1 < K && K < N && N < 100)
        {
            for (int numberN = N; numberN > 1; numberN--)
            {
                factorialN *= numberN;
                if (numberN > K)
                {
                    factorialKandN *= multiKandN;
                    multiKandN--;
                }
            }
            
            for (int numberK = K; numberK > 1; numberK--)
            {
                factorialK *= numberK;
            }
            result = factorialN / (factorialK * factorialKandN);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

