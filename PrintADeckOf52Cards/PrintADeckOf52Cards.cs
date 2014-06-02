using System;

class PrintADeckOf52Cards
{
    /*Write a program that generates and prints all possible cards 
     * from a standard deck of 52 cards (without the jokers). 
     * The cards should be printed using the classical notation 
     * (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. 
     * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
     * Use 2 nested for-loops and a switch-case statement.*/
    static void Main()
    {
        int lance = 6;
        int heart = 3;
        int diamond = 4;
        int spade = 5;
        for (int faces = 0; faces <= 12; faces++)
        {
            Console.WriteLine();
            for (int colors = 0; colors <= 3; colors++)
            {
                switch (faces)
                {
                    case 0: Console.Write("  " + 2); break;
                    case 1: Console.Write("  " + 3); break;
                    case 2: Console.Write("  " + 4); break;
                    case 3: Console.Write("  " + 5); break;
                    case 4: Console.Write("  " + 6); break;
                    case 5: Console.Write("  " + 7); break;
                    case 6: Console.Write("  " + 8); break;
                    case 7: Console.Write("  " + 9); break;
                    case 8: Console.Write(" " + 10); break;
                    case 9: Console.Write("  J"); break;
                    case 10: Console.Write("  Q"); break;
                    case 11: Console.Write("  K"); break;
                    case 12: Console.Write("  A"); break;
                    default:
                    break;
                }

                switch (colors)
                {
                    case 0:
                        Console.Write((char)lance);
                        break;
                    case 1:
                        Console.Write((char)heart);
                        break;
                    case 2:
                        Console.Write((char)diamond);
                        break;
                    case 3:
                        Console.Write((char)spade);
                        break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine();
    }
}

