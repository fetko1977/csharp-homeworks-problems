using System;

class NumbersFromOneToN
{
    /*Write a program that enters from the console a 
     * positive integer n and prints all the numbers from 
     * 1 to n, on a single line, separated by a space.*/
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter number n:");
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        if (n < number)
        {
            Console.WriteLine("Invalid Input!");
        }
        else
        {
            while (number <= n)
            {
                Console.Write(number + " ");
                number++;
            }
        }
        Console.WriteLine();
    }
}

