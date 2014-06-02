using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            /*Write a program that reads 3 numbers: 
             * an integer a (0 ≤ a ≤ 500), a floating-point b 
             * and a floating-point c and prints them in 4 
             * virtual columns on the console. Each column 
             * should have a width of 10 characters. The number a 
             * should be printed in hexadecimal, left aligned; 
             * then the number a should be printed in binary form, 
             * padded with zeroes, then the number b should be printed 
             * with 2 digits after the decimal point, right aligned; 
             * the number c should be printed with 3 digits after the 
             * decimal point, left aligned.*/
            Console.WriteLine("Please enter integer a in the interval between 0 and 500:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter floating point b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter floating point c:");
            float c = float.Parse(Console.ReadLine());
            string aBinary = Convert.ToString(a, 2);
            aBinary = aBinary.PadLeft(10, '0');
            Console.WriteLine("|{0, -10:X2}|{1, -10}|{2, 10:F2}|{3, 10:F3}|", a, aBinary, b, c);
        }
    }
}
