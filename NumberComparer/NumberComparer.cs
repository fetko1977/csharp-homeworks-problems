using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            /*Write a program that gets two numbers from 
             * the console and prints the greater of them. 
             * Try to implement this without if statements.*/
            Console.WriteLine("Please enter number a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number b:");
            double b = double.Parse(Console.ReadLine());
            double greater = Math.Max(a, b);
            Console.WriteLine("The greater number is {0}", greater);
        }
    }
}
