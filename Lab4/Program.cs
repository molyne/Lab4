using System;

namespace TheGameFromHell
{
    class Program
    {
        static void Main(string[] args)
        {

            /* High score
             John : 34*/    //två till ska spela spelet

            Beginning start = new Beginning();

            start.Instructions();


            Map map = new Map();

            map.PrintMap();
         

            Console.ReadKey();


        }


    }
}

