using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{

    public class Map 
    {

        const int ROWS = 8, COLUMS = 20;

        private int row;
        private int column;

        public int Row { get { return row; } set { row = value; } }
        public int Column { get { return column; } set { column = value; } }

        public Square [,] squares = new Square [ROWS, COLUMS];

        bool enterMonsterRoom = false;

        Player p = new Player();

       int positionXPlayer = 1; //spelarens position
       int positionYPlayer = 1; //spelaren position
        bool updateMap = true;

        static int counter = 0;


        public void PrintThis()
        {

            Console.WriteLine("Write this");

        }
 

        public void PrintMap()
        {


            do
            {

                for (int column = 0; column < squares.GetLength(0); column++)
                {
                    for (int row = 0; row < squares.GetLength(1); row++)
                    {

                        if (row == 4 && column == 4 || row == 13 && column == 4 || column == 6 && row == 8)
                        {
                            squares[column, row] = new Door();
                        }

                        else if (row == 0 || row == 19 || column == 0 || column == 7 || row == 8 || column ==4)
                        {

                            squares[column, row] = new Wall();
                        }  
                        else if (row == 18 && column== 1)
                        {
                            squares[column, row] = new ExitRoom();
                        }
                        else if (row == 13 && column == 1)
                        {
                            squares[column, row] = new EmptyRoom();
                        }
                        else if (row ==1 && column == 3 || row == 1 && column==6 || row == 14 && column == 6)
                        {
                            squares[column, row] = new RoomWithKey();
                        }
                        else if (row == 13 && column ==6 || row ==6 && column==5 || row == 11 && column ==2)
                        {
                            squares[column, row] = new RoomWithMonster();
                        }
           
                        else
                        {
                            squares[column, row] = new Floor(); 
                        }
                        if (positionXPlayer == row && positionYPlayer == column)
                        {
                            Player p = new Player();

                           Console.Write( p.PrintSymbol());

                            if (squares[column, row] is RoomWithMonster)
                            {
                                //RoomWithMonster m = new RoomWithMonster();

                                enterMonsterRoom = true;
                              
                               

                            }

                        }

                       


                        else
                            Console.Write(squares[column, row].PrintSymbol());
                        
                    }

                    Console.WriteLine(" ");
                }

                Console.WriteLine("Move: "+counter); //här kan man lägga grejer utan att det försvinner

                if (enterMonsterRoom)
                {
                    RoomWithMonster m = new RoomWithMonster();

                    m.PrintRoomInfo();

                    counter += 23;

                    enterMonsterRoom = false;
                }
                

                ConsoleKeyInfo move = Console.ReadKey();

              

                switch (move.Key) //lägg till hinder här också och dörrar och tomma rum. I en metod typ ispossible to move?
                {
                    case ConsoleKey.D:

                        if  (positionXPlayer < 18) //ändra magical numbers
                                positionXPlayer += 1; //går ett steg till höger
                        counter++;

                        break;
                    case ConsoleKey.A:
                        if (positionXPlayer > 1)
                            positionXPlayer -= 1; //går ett steg till vänster
                        counter++;
                        break;
                    case ConsoleKey.W:
                        if (positionYPlayer > 1)
                            positionYPlayer -= 1; //går uppåt ett steg
                        counter++;
                        break;
                    case ConsoleKey.S:
                        if (positionYPlayer < 7)
                            positionYPlayer += 1; //går neråt ett steg
                        counter++;
                        break;
                }



                Console.Clear();
               

            } while (updateMap);

            PrintSteps();
            
        }
        
     

        static void PrintSteps()
        {
            Console.WriteLine($"steg :{counter}");
            Console.ReadKey();
        }
    
    }
}
