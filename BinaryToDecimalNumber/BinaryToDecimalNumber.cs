using System;

class BinaryToDecimalNumber
{
    /*Using loops write a program that converts a binary integer number 
     * to its decimal form. The input is entered as string. The output 
     * should be a variable of type long. Do not use the built-in .NET functionality.*/
    static void Main()
    {
        Console.Write("Please enter a binary represantation of number: ");
        string binary = Console.ReadLine();
        long result = 0;
        for (int index = binary.Length - 1; index >= 0; index--)
        {
            if (binary[index] == '0')
            {
                continue;
            }
            else
            {
                result += (long) Math.Pow(2, (binary.Length - 1) - index);
            }
        }
        Console.WriteLine("The result in decimal represantation is: {0}", result);
    }
}
