using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInIntervaleDividable
{
    class NumbersInIntervaleDividable
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two positive 
             * integer numbers and prints how many numbers p 
             * exist between them such that the reminder of 
             * the division by 5 is 0.*/
            Console.WriteLine("Please enter number greater than 0:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number greater than previous number:");
            int second = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = first; i < second; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The numbers in interval between {0} and {1} dividable by 5 without reminder are {2}.", first, second, count);
        }
    }
}
