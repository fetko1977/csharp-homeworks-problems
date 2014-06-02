using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbersN
{
    class SumOfNumbersN
    {
        static void Main(string[] args)
        {
            /*Write a program that enters a number n and after 
             * that enters more n numbers and calculates and 
             * prints their sum. Note that you may need to use 
             * a for-loop.*/
            Console.WriteLine("Please enter integer number greater than O - ");
            int lengthNumbers = int.Parse(Console.ReadLine());

            double result = 0;
            for (int i = 0; i < lengthNumbers; i++)
            {
                Console.WriteLine("Please enter number:");
                double n = double.Parse(Console.ReadLine());
                result = result + n;
            }
            Console.WriteLine("the sum of entered numbers is {0}.", result);
        }
    }
}
