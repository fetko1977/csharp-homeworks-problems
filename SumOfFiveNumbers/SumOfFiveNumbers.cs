using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that enters 5 numbers 
             * (given in a single line, separated by a space), 
             * calculates and prints their sum.*/
            Console.Write("Please enter five numbers: ");
            string[] userInput = Console.ReadLine().Split();
            double a = double.Parse(userInput[0]);
            double b = double.Parse(userInput[1]);
            double c = double.Parse(userInput[2]);
            double d = double.Parse(userInput[3]);
            double e = double.Parse(userInput[4]);
            double sum = a + b + c + d + e;
            Console.WriteLine("The sum of {0}, {1}, {2}, {3}, {4} is {5}.", a, b, c, d, e, sum);
        }
    }
}
