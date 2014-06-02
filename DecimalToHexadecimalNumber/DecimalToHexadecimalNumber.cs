using System;

class DecimalToHexadecimalNumber
{
    /*Using loops write a program that converts an integer number to its hexadecimal representation. 
     * The input is entered as long. The output should be a variable of type string. 
     * Do not use the built-in .NET functionality.*/
    static void Main()
    {
        Console.Write("Please enter a number: ");
        long number = long.Parse(Console.ReadLine());
        long original = number;
        long divRest;
        string hex = string.Empty;
        while (number > 0)
        {

            string current = string.Empty;
            divRest = number % 16;
            switch (divRest)
            {
                case 10: current = "A"; break;
                case 11: current = "B"; break;
                case 12: current = "C"; break;
                case 13: current = "D"; break;
                case 14: current = "E"; break;
                case 15: current = "F"; break;
                default: current = divRest.ToString(); break;
            }
            number /= 16;
            hex = current + hex;
        }
        Console.WriteLine("The hexadecimal representation of {0} is : {1}", original, hex);
    }
}

