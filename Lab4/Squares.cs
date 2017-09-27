using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class  Squares
    {
       
        

        const int ROWS = 5, COLUMS = 13;

        private int row;
        private int column;

        public int Row { get { return row; } set { row = value; } }
        public int Column { get { return column; } set { column = value; } }

        public Squares[,] squares = new Squares[ROWS, COLUMS]; 
        
          

        int positionXPlayer = 3; //spelarens position
        int positionYPlayer = 2; //spelaren position
        bool updateMap = true;


        
        
       

        public void PrintMap()
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
                        else if (positionXPlayer == row && positionYPlayer == column)
                        {
                            squares[column, row] = new Player(); // new player
                        }
                        else
                        {
                            squares[column, row] = new EmptyRoom(); //TODO tomt rum
                        }

                        Console.Write(squares[column, row]);
                    }

                    Console.WriteLine(" ");
                }


                ConsoleKeyInfo move = Console.ReadKey();


              
                switch (move.Key)
                {
                    case ConsoleKey.D:

                        if (positionXPlayer < 11)
                            positionXPlayer += 1; //går ett steg till höger
                        break;
                    case ConsoleKey.A:
                        if (positionXPlayer > 1)
                            positionXPlayer -= 1; //går ett steg till vänster
                        break;
                    case ConsoleKey.W:
                        if (positionYPlayer > 1)
                            positionYPlayer -= 1; //går uppåt ett steg
                        break;
                    case ConsoleKey.S:
                        if (positionYPlayer < 3)
                            positionYPlayer += 1; //går neråt ett steg
                        break;
                }
                Console.Clear();
            } while (updateMap);




        }




    }
}
