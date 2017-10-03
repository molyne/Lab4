using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameFromHell
{
    class Beginning
    {
        public void Instructions()
        {
            Console.WriteLine("Welcome to the maze!");
            Console.WriteLine("Your goal is to find the path to the exit with as little moves as possible.");
            Console.WriteLine("You move yourself with W,A,S,D. A is left. D is right. W is up. S is down. ");
            Console.WriteLine();
            Console.WriteLine("There is obstacles and rooms you can visit when you move over them.");
            Console.WriteLine("To move forward in the maze you have to find keys to open the door.");
            Console.WriteLine("You can only use one key for each door. So you have to find a new key when you used one. ");
            Console.WriteLine();
            Console.WriteLine("k: room with a key, X: the exit , D: door, m: room with a monster, e: a room, #: wall, @: you. ");
            Console.WriteLine();
            Console.WriteLine("Good luck! Press a key to start the game.");

            Console.ReadKey();

            Console.Clear();

        }

    }
}
