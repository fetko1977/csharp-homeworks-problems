using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumThreeNumbers
{
    class SumThreeNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that reads 3 real numbers from the console and prints their sum.*/
            Console.WriteLine("Please enter number a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of numbers {0}, {1}, {2} is {3}", a, b, c, a + b +c);
        }
    }
}
