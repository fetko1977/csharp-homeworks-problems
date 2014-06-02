using System;
using System.Linq;

class RandomizeTheNumbers1toN
{
    /*Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/
    static void Main()
    {
        Console.Write("Please enter number n - ");
        int n = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int value;
        if (n >= 1)
        {
            bool[] printedNums = new bool[n + 1];
            for (int index = 1; index <= n; index++)
            {
                value = rand.Next(1, n + 1);
                if (printedNums[value] == false)
                {
                    Console.Write(value + " ");
                    printedNums[value] = true;
                }
                else
                {
                    index--;
                }
            }
            Console.WriteLine();
          }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

