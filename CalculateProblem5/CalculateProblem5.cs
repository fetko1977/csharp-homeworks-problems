using System;

class CalculateProblem5
{
    /*Write a program that, for a given two integer numbers n and x, 
     * calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. 
     * Print the result with 5 digits after the decimal point.*/
    static void Main()
    {
        Console.WriteLine("Please enter number x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number n greater than 0:");
        int n = int.Parse(Console.ReadLine());
        double factorial = 1;
        double multiplicationX = 1;
        double sum = 1;
        if (n < 1)
        {
            Console.WriteLine("Invalid Input of n number");
        }
        else
        {
            Console.Write("The sum of 1");
            for (int number = 1; number <= n; number++)
            {
                factorial *= number;
                multiplicationX *= x;
                sum = sum + factorial / multiplicationX;
                Console.Write(" + !{0}/{0}*{0}", number);
            }
            Console.WriteLine(" = {0:F5}", sum);
        }
    }
}

