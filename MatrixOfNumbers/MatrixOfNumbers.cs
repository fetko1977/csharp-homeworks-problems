using System;

class MatrixOfNumbers
{
    /*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
     * and prints a matrix like in the examples below. Use two nested loops.*/
    static void Main()
    {
        Console.Write("Please eneter number between 1 and 20 - ");
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 20)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                Console.Write("{0, 4}", rows);
                for (int cols = rows + 1; cols <= (n + rows) - 1; cols++)
                {
                    Console.Write("{0, 4}", cols);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

