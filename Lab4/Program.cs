using System;

namespace övning11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 13]; //kom ihåg att lägga in arryen i forloopen kolla labb 2.

            int positionXPlayer = 3; //spelarens position
            int positionYPlayer = 2; //spelaren position
            bool updateMap = true;


            do
            {

                for (int y = 0; y < array.GetLength(0); y++)
                {
                    for (int x = 0; x < array.GetLength(1); x++)
                    {


                        if (x == 0 || x == 12 || y == 0 || y == 4)
                        {
                            array[y, x] = "#";

                        }
                        else if (positionXPlayer == x && positionYPlayer == y)
                        {
                            array[y, x] = "@";
                        }
                        else
                        {
                            array[y, x] = "-";
                        }

                        Console.Write(array[y, x]);
                    }

                    Console.WriteLine(" ");
                }
                //ConsoleKeyInfo choice;

                //bool keepPrinting = true;

                //while (keepPrinting)
                //{

                ConsoleKeyInfo move = Console.ReadKey();


                //spelaren rör sig
                switch (move.Key)
                {
                    case ConsoleKey.D:

                        if (positionXPlayer > 0)
                            positionXPlayer += 1; //går ett steg till höger
                        else
                            Console.WriteLine();
                        break;
                    case ConsoleKey.A:
                        positionXPlayer -= 1; //går ett steg till vänster
                        break;
                    case ConsoleKey.W:
                        positionYPlayer -= 1; //går uppåt ett steg
                        break;
                    case ConsoleKey.S:
                        positionYPlayer += 1; //går neråt ett steg
                        break;
                    default:
                        Console.WriteLine("Enter a,s,d,w");
                        break;
                }
                Console.Clear();
            } while (updateMap);
            {

            }


        }





    }
}

