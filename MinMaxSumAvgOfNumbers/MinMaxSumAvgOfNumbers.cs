using System;

class MinMaxSumAvgOfNumbers
{
    /*Write a program that reads from the console a sequence 
     * of n integer numbers and returns the minimal, the maximal number, 
     * the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
     * The input starts by the number n (alone in a line) followed by n lines, each holding an 
     * integer number. The output is like in the examples below.*/
    static void Main()
    {
        Console.WriteLine("Please enter number greater than 0:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (n < 1)
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            int avgDivider = n;
            while (n > 0)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                sum += number;
                n--;
            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Avg: {0:F2}", (double)(sum / avgDivider));
        }
    }
}

