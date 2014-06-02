using System;
using System.Numerics;

class CatalanNumbers
{
    /*In combinatorics, the Catalan numbers are calculated by the following formula:
     Write a program to calculate the nth Catalan number by given n (1 < n < 100).
     Formula: (2n)! / (n + 1)! * n! */
    static void Main()
    {
        Console.Write("Please enter number N -");
        int N = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialNdouble = 1;
        BigInteger result;
        if (1 < N && N < 100)
        {
            for (int numberN = N * 2; numberN > 1; numberN--)
            {
                factorialNdouble *= numberN;
                if (numberN > 1 && numberN <= N)
                {
                    factorialN *= numberN;
                }
            }
            BigInteger factorialNplus = factorialN + factorialN * N;
            result = factorialNdouble / (factorialNplus * factorialN);
            Console.WriteLine("The {0}th member from Catalan Numbers is - {1}.", N, result);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

