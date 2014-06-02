using System;

class DecimalToBinaryNumber
{
    /*Using loops write a program that converts an integer number to its binary representation. 
     * The input is entered as long. The output should be a variable of type string. 
     * Do not use the built-in .NET functionality.*/
    static void Main()
    {
        Console.Write("Please enter a number: ");
        long number = long.Parse(Console.ReadLine());
        string binary = string.Empty;
        long divisionRest;
        while (number != 0)
        {
            divisionRest = number % 2;
            binary = divisionRest.ToString() + binary;
            number /= 2;
        }
        Console.WriteLine(binary);
    }
}

