using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a number n and 
             * prints on the console the first n members 
             * of the Fibonacci sequence (at a single line, 
             * separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13,
             * 21, 34, 55, 89, 144, 233, …. Note that you may 
             * need to learn how to use loops.*/
            Console.WriteLine("Please enter number:");
            int length = int.Parse(Console.ReadLine());
            BigInteger one = 0;
            BigInteger two = 1;
            BigInteger three = 1;
            Console.WriteLine("The first {0} numbers from Fibonacci sequence is:", length);
            Console.Write(two + " " + three + " ");
            for (int i = 0; i < length - 2; i++)
            {
                one = two;
                two = three;
                three = one + two;
                Console.Write(three + " ");
            }
            Console.WriteLine();
        }
    }
}
