using System;

class OddAndEvenProduct
{
    /*You are given n integers (given in a single line, separated by a space). 
     * Write a program that checks whether the product of the odd elements is 
     * equal to the product of the even elements. Elements are counted from 1 to n, 
     * so the first element is odd, the second is even, etc.*/
    static void Main()
    {
        Console.Write("Please enter number n: ");
        int n = int.Parse(Console.ReadLine());
        if (n >= 1)
        {
            int productOdd = 1;
            int productEven = 1;
            string[] numbers = Console.ReadLine().Split();
            for (int num = 0; num < n; num++)
            {
                int number = Convert.ToInt32(numbers[num]);
                if (num % 2 == 0)
                {
                    productEven *= number;
                }
                else
                {
                    productOdd *= number;
                }
            }
            if (productEven == productOdd)
            {
                Console.WriteLine("Yes!");
                Console.WriteLine("Product = {0}", productEven);
            }
            else
            {
                Console.WriteLine("No!");
                Console.WriteLine("Odd_product = {0}", productOdd);
                Console.WriteLine("Even_product = {0}", productEven);
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

