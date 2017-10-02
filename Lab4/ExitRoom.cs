using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameFromHell
{
    class ExitRoom : Square
    {
       
        public override string PrintSymbol()
        {
            return "X";
        }

        public void PrintHighScore (int numberofmoves)
        {
            if (numberofmoves <= 34)
            {
                Console.WriteLine("You are amazing, u took the shortest way possible!");
            }
            else if (numberofmoves > 34 && numberofmoves < 40)
            {
                Console.WriteLine("It's good, but you can find a shorter way. Try again!");
            }
            else
                Console.WriteLine("Do you have a bad local sense? Because your score is reeeeally bad. Try again!");

            Console.WriteLine($"You took {numberofmoves} steps.");
        }

     

    }
}
