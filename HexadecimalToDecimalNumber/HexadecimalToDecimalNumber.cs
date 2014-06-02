using System;

class HexadecimalToDecimalNumber
{
    /*Using loops write a program that converts a hexadecimal integer number to its decimal form. 
     * The input is entered as string. The output should be a variable of type long. Do not use 
     * the built-in .NET functionality.*/
    static void Main()
    {
        Console.Write("Please enter hex representation of a number: ");
        string hex = Console.ReadLine();
        long result = 0;
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int numberHex;
            switch (hex[i])
            {
                case 'A': numberHex = 10; break;
                case 'B': numberHex = 11; break;
                case 'C': numberHex = 12; break;
                case 'D': numberHex = 13; break;
                case 'E': numberHex = 14; break;
                case 'F': numberHex = 15; break;
                default: numberHex = (int)hex[i] - 48; break;
            }
            long power = (long)Math.Pow(16, (hex.Length - 1) - i);
            result += (numberHex * power);
        }
        Console.WriteLine("The decimal representation is {0}", result);
    }
}

