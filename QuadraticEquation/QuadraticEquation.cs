using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the coefficients a, b and c 
             * of a quadratic equation ax2 + bx + c = 0 and solves it 
             * (prints its real roots).*/
            Console.WriteLine("Please enter number for coefficent a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number for coefficent b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number for coefficent c:");
            double c = double.Parse(Console.ReadLine());
            double discriminantD = (b * b) - (4 * a * c);
            if (discriminantD < 0)
            {
                Console.WriteLine("Quadratic equation no have real roots!");
            }
            else if (discriminantD == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("Quadratic equation have one real root: {0}!", root);
            }
            else
            {
                double rootOne = -(b + Math.Sqrt(discriminantD)) / (2 * a);
                double rootTwo = -(b - Math.Sqrt(discriminantD)) / (2 * a);
                Console.WriteLine("Quadratic equation have two real root: {0} and {1}!", rootOne, rootTwo);
            }
        }
    }
}
