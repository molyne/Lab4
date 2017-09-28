using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Wall : Squares
    {
        public override string PrintSymbol()
        {
            return "#";
        }

        bool updateMap = true;

        public void PrintMap2()
        {


            do
            {

                for (int column = 0; column < squares.GetLength(0); column++)
                {
                    for (int row = 0; row < squares.GetLength(1); row++)
                    {



                        if (row == 0 || row == 12 || column == 0 || column == 4)
                        {

                            squares[column, row] = new Wall();



                        }
                        //else if (positionXPlayer == row && positionYPlayer == column)
                        //{
                        //    squares[column, row] = "@"; // new player
                        //}
                        else
                        {

                            squares[column, row] = new EmptyRoom();
                        }

                        Console.Write(squares[column, row].PrintSymbol()); //vad ska det stå här

                    }

                    Console.WriteLine(" ");
                }



                ConsoleKeyInfo move = Console.ReadKey();



                Console.Clear();
            } while (updateMap);








        }


    }     }

