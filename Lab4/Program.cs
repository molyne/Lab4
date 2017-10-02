using System;

namespace TheGameFromHell
{
    class Program
    {
        static void Main(string[] args)
        {

            Beginning start = new Beginning();

            start.Instructions();


            Map map = new Map();

            map.PrintMap();
         

            Console.ReadKey();


        }


    }
}

