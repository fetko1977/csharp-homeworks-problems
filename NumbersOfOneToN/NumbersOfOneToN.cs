using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersOfOneToN
{
    class NumbersOfOneToN
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer number n 
             * from the console and prints all the numbers in 
             * the interval [1..n], each on a single line. 
             * Note that you may need to use a for-loop.*/
            Console.WriteLine("Please enter a number n greater or equal to 1 - ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
