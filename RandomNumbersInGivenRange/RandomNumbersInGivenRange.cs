using System;

class RandomNumbersInGivenRange
{
    /*Write a program that enters 3 integers n, min and max (min ≤ max) 
     * and prints n random numbers in the range [min...max].*/
    static void Main()
    {
        Console.Write("Please enter number n with value greater or equal to 1 - ");
        int n = int.Parse(Console.ReadLine());
        if (n >= 1)
        {
            Console.Write("Please enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please enter max: ");
            int max = int.Parse(Console.ReadLine());
            if (min >= max)
            {
                Console.WriteLine("The value of min can't be greater or equal to max value!");
            }
            else
            {
                Random random = new Random();
                for (int rand = 0; rand < n; rand++)
                {
                    Console.Write(random.Next(min, max + 1) + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input of number n!");
        }
    }
}

