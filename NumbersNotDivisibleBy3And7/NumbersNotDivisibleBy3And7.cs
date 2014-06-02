using System;

class NumbersNotDivisibleBy3And7
{
    /*Write a program that enters from the console a positive integer 
     * n and prints all the numbers from 1 to n not divisible by 3 and 7, 
     * on a single line, separated by a space.*/
    static void Main()
    {
        Console.WriteLine("Please enter a positive number greater than 1:");
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        if (n < 2)
        {
            Console.WriteLine("Invalid Input!");
        }
        else
        {
            Console.WriteLine("Numbers from {0} to {1} not divisible by 3 or 7 are:", number, n);
            while (number <= n)
            {
                if (number % 3 == 0 || number % 7 == 0)
                {
                    number++;
                }
                else
                {
                    Console.Write(number + " ");
                    number++;
                }
            }
            Console.WriteLine();
        }
    }
}

