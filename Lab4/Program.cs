using System;

namespace TheGameFromHell
{
    class Program
    {
        static void Main(string[] args)
        {

            /* High score
             John : 39
             Joakim: 34
             Simone: 34*/    //två till ska spela spelet

            Beginning start = new Beginning();

            start.Instructions();


            Map map = new Map();

            map.PrintMap();
         

            Console.ReadKey();


        }


    }
}

