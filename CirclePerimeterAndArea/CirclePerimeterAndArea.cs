using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            /*Write a program that reads the radius r of a 
             * circle and prints its perimeter and area formatted 
             * with 2 digits after the decimal point.*/
            Console.WriteLine("Please enter a radius:");
            double r = double.Parse(Console.ReadLine());
            double perimeterCircle = 2 * (Math.PI * r);
            double areaCircle = Math.PI * (r * r);
            Console.WriteLine("The perimeter of the circle is {0:F2} and the area is {1:F2}.", perimeterCircle, areaCircle);
        }
    }
}
