using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPrintSymbol[] print = new IPrintSymbol[2];





            //print[0] = new Wall();
            //print[1] = new EmptyRoom();

            //for (int i = 0; i < print.Length; i++)
            //    Console.WriteLine(print[i].PrintSymbol());

            Map map = new Map();

            map.PrintMap();



            // Player p = new Player();








            //Använd en enum för att representera olika sorters rutor.
            //Använd ett interface för alla klasser som har ett tecken som kan visas på kartan.




            Console.ReadKey();


        }


    }
}

