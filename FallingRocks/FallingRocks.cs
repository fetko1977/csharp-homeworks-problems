using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implement the "Falling Rocks" game in the text console. 
 * A small dwarf stays at the bottom of the screen and can move left 
 * and right (by the arrows keys). A number of rocks of different sizes 
 * and forms constantly fall down and you need to avoid a crash.
   Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed 
 * with appropriate density. The dwarf is (O). Ensure a constant game 
 * speed by Thread.Sleep(150).Implement collision detection and scoring system.
 */

    struct Rocks // Structure to hold properties for rocks objects
    {
        public int x;
        public int y;
        public string symbol;
        public ConsoleColor color;
    }

    class FallingRocks
    {
        //Method for drawing the falling rocks and the user dwarf
        static void drawObject(int x, int y, string symbol, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }
        //Method for displaying the game info and score
        static void writeInfo(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            //-----Here i initialize two variables, one for playground width and one for game score
            int playgroundWidth = 50;
            int score = 0;
            int livesCount = 5;
            double speedFall = 100.0;
            //Here I set the width and height of the game screen
            Console.BufferWidth = Console.WindowWidth = 70;
            Console.BufferHeight = Console.WindowHeight = 35;
            //----Here i create the Dwarf Object--------
            Rocks Dwarf = new Rocks();
            Dwarf.x = playgroundWidth / 2;
            Dwarf.y = Console.WindowHeight - 1;
            Dwarf.symbol = "O-O";
            Dwarf.color = ConsoleColor.Magenta;
            //------Here I create one list with rocks obj. and one random generator.
            List<Rocks> Rock = new List<Rocks>();
            Random randGen = new Random();
            //------start of the main while loop------
            while (true)
            {
                speedFall++;
                if (speedFall > 400)
                {
                    speedFall = 400;
                }
                bool hit = false;
                {
                    //------Here I create the falling rock objects-------
                    Rocks newRock = new Rocks();
                    newRock.x = randGen.Next(0, playgroundWidth);
                    newRock.y = 0;
                    //------Switch Loop to generate diferent symbols and colors for the rocks
                    switch (randGen.Next(0, 10))
                    {
                        case 0:
                            newRock.symbol = "^^^";
                            newRock.color = ConsoleColor.Green;
                            break;
                        case 1:
                            newRock.symbol = "@@@";
                            newRock.color = ConsoleColor.White;
                            break;
                        case 2:
                            newRock.symbol = "***";
                            newRock.color = ConsoleColor.Red;
                            break;
                        case 3:
                            newRock.symbol = "&&&";
                            newRock.color = ConsoleColor.White;
                            break;
                        case 4:
                            newRock.symbol = "+++";
                            newRock.color = ConsoleColor.Cyan;
                            break;
                        case 5:
                            newRock.symbol = "%%%";
                            newRock.color = ConsoleColor.White;
                            break;
                        case 6:
                            newRock.symbol = "$$$";
                            newRock.color = ConsoleColor.White;
                            break;
                        case 7:
                            newRock.symbol = "###";
                            newRock.color = ConsoleColor.White;
                            break;
                        case 8:
                            newRock.symbol = "!!!";
                            newRock.color = ConsoleColor.White;
                            break;
                        case 9:
                            newRock.symbol = "...";
                            newRock.color = ConsoleColor.Yellow;
                            break;
                        case 10:
                            newRock.symbol = ";;;";
                            newRock.color = ConsoleColor.White;
                            break;
                        default:
                            break;
                    }
                    Rock.Add(newRock);
                }
                //------Here I check if user is press any key from the keyboard
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey();
                    }

                    if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        if (Dwarf.x - 1 >= 0)
                        {
                            Dwarf.x = Dwarf.x - 1;
                        }
                    }
                    else if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        if (Dwarf.x + 1 <= playgroundWidth)
                        {
                            Dwarf.x = Dwarf.x + 1;
                        }
                    }
                }
                //-------here is the for loop for moving the rocks through the screen--------
                List<Rocks> newListRocks = new List<Rocks>();
                for (int i = 0; i < Rock.Count; i++)
                {
                    Rocks oldRocks = Rock[i];
                    Rocks newRock = new Rocks();
                    newRock.x = oldRocks.x;
                    newRock.y = oldRocks.y + 1;
                    newRock.symbol = oldRocks.symbol;
                    newRock.color = oldRocks.color;
                    //----here I check if my Dwarf is hit by rock and what color is the rock
                    if (newRock.x == Dwarf.x && newRock.y == Dwarf.y && newRock.color == ConsoleColor.White)
                    {
                        hit = true;
                        livesCount--;
                        if (livesCount <= 0)
                        {
                            writeInfo(55, 10, "GAME OVER!", ConsoleColor.Red);
                            writeInfo(55, 12, "Press [ENTER]", ConsoleColor.Red);
                            writeInfo(55, 13, "to exit!", ConsoleColor.Red);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    //-----scoring and bonus system---------
                    if (newRock.x == Dwarf.x && newRock.y == Dwarf.y && newRock.color != ConsoleColor.White)
                    {
                        switch (newRock.symbol)
                        {
                            case "^^^":
                                score = score + 10;
                            break;
                            case "***":
                            score = score + 50;
                            break;
                            case "+++":
                            livesCount++;
                            break;
                            case "...":
                            speedFall--;
                            break;
                            default:
                                break;
                        }
                    }
                    if (newRock.y < Console.WindowHeight)
                    {
                        newListRocks.Add(newRock);
                    }
                }
                Rock = newListRocks;
                Console.Clear();
                if (hit)
                {
                    newListRocks.Clear();
                    drawObject(Dwarf.x, Dwarf.y, "XXX", ConsoleColor.DarkRed);
                }
                else
                {
                    drawObject(Dwarf.x, Dwarf.y, Dwarf.symbol, Dwarf.color);
                }
                //-----here I draw the rocks with foreach loop-------
                foreach (Rocks rocks in Rock)
                {
                    drawObject(rocks.x, rocks.y, rocks.symbol, rocks.color);
                }
                writeInfo(55, 2, "LIVES: " + livesCount, ConsoleColor.Red);
                writeInfo(55, 3, "SCORE: " + score, ConsoleColor.DarkGreen);
                System.Threading.Thread.Sleep((int)(600 - speedFall));
            }
        }
    }

