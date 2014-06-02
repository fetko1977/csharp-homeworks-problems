using System;

class SpiralMatrix
{
    /*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
     * and prints a matrix holding the numbers from 1 to n*n in the form of square spiral 
     * like in the examples below.*/
    static void Main()
    {
        Console.Write("Please enter number n greater than 0 and smaller than 20: ");
        int n = int.Parse(Console.ReadLine());
        if (0 < n && n < 20)
        {
            int[,] spiralMatrix = new int[n, n];
            int row = 0;
            int col = 0;
            string printDirection = "right";
            int maxRotation = n * n;
            Console.WriteLine();
            for (int i = 1; i <= maxRotation; i++)
            {
                if (printDirection == "right" && (col > n - 1 || spiralMatrix[row, col] != 0))
                {
                    printDirection = "down";
                    col--;
                    row++;
                }
                if (printDirection == "down" && (row > n - 1 || spiralMatrix[row, col] != 0))
                {
                    printDirection = "left";
                    row--;
                    col--;
                }
                if (printDirection == "left" && (col < 0 || spiralMatrix[row, col] != 0))
                {
                    printDirection = "up";
                    row--;
                    col++;
                }
                if (printDirection == "up" && (row < 0 || spiralMatrix[row, col] != 0))
                {
                    printDirection = "right";
                    row++;
                    col++;
                }

                spiralMatrix[row, col] = i;

                if (printDirection == "right")
                {
                    col++;
                }
                if (printDirection == "down")
                {
                    row++;
                }
                if (printDirection == "left")
                {
                    col--;
                }
                if (printDirection == "up")
                {
                    row--;
                }
            }
            //print spiral matrix
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0, 4}", spiralMatrix[r, c]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
        
    }
}

