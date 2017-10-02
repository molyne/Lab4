using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{

    public class Map 
    {

        const int COLUMNS = 8, ROWS = 20;

        private int row;
        private int column;

        public int Row { get { return row; } set { row = value; } }
        public int Column { get { return column; } set { column = value; } }

        public Square [,] squares = new Square [COLUMNS, ROWS];

      

        Player p = new Player();

       
        bool updateMap = true;

       
        //int keys = 0;
 
      

        RoomWithMonster m = new RoomWithMonster();
        EmptyRoom e = new EmptyRoom();
        RoomWithKey k = new RoomWithKey();
        ExitRoom x = new ExitRoom();

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

                        else if (row == 0 || row == ROWS -1 || column == 0 || column == COLUMNS -1 || row == 8 || column ==4)
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
                        if (p.PositionXPlayer == row && p.PositionYPlayer == column)
                        {
                            Player p = new Player();

                           Console.Write( p.PrintSymbol());

                            if (squares[column, row] is RoomWithMonster)
                            {

                                m.EnterMonsterRoom = true;


                            }
                            if (squares[column, row] is EmptyRoom)
                            {

                                e.EnterEmptyRoom = true;
                            }
                            if (squares[column, row] is RoomWithKey)
                            {
                                k.EnterRoomWithKey = true;
                                k.AmountOfKeys = 1;
                                
                            }

                        }

                        else
                            Console.Write(squares[column, row].PrintSymbol());
                        
                    }

                    Console.WriteLine(" ");
                }
                
                Console.Write("Moves: "+p.Moves); //här kan man lägga grejer utan att det försvinner
                Console.Write(" Keys: "+k.AmountOfKeys);
                Console.WriteLine();


                if (m.EnterMonsterRoom)
                    p.Moves += 23;
                m.CheckRoom();
                e.CheckRoom();
                k.CheckRoom();
               


                p.Rotation(squares,  p.Moves, k.GotKey, k.AmountOfKeys);

                //ConsoleKeyInfo move = Console.ReadKey();

                //switch (move.Key) //lägg till hinder här också och dörrar och tomma rum. I en metod typ ispossible to move?
                //{
                //    case ConsoleKey.D:
                //        {
                //            if (squares[p.PositionYPlayer, p.PositionXPlayer + 1] is Wall)

                //                break;
                //            if (squares[p.PositionYPlayer, p.PositionXPlayer + 1] is Door)

                //            {
                //                if (k.GotKey)
                //                    p.PositionXPlayer += 1;
                //               k.GotKey = false;
                //                k.AmountOfKeys = 0;
                //                break;
                //            }
                //            else
                //               p.PositionXPlayer += 1;
                //            m.Counter++;
                //            break;
                //        }

                //    case ConsoleKey.A:

                //        {
                //            if (squares[p.PositionYPlayer, p.PositionXPlayer - 1] is Wall)

                //                break;

                //            else
                //                p.PositionXPlayer -= 1;
                //            m.Counter++;
                //        }
                //        break;

                //    case ConsoleKey.W:

                //        if (squares[p.PositionYPlayer - 1, p.PositionXPlayer] is Wall)
                //        {
                //            break;
                //        }

                //        if (squares[p.PositionYPlayer + -1, p.PositionXPlayer] is Door)

                //        {
                //            if (k.GotKey)
                //                p.PositionYPlayer -= 1;
                //            k.GotKey = false;
                //            k.AmountOfKeys = 0;
                //            break;
                //        }


                //        else
                //            p.PositionYPlayer -= 1;
                //        m.Counter++;
                //        break;

                //    case ConsoleKey.S:

                //        if (squares[p.PositionYPlayer + 1, p.PositionXPlayer] is Wall)

                //            break;
                //        if (squares[p.PositionYPlayer + 1, p.PositionXPlayer] is Door)

                //        {
                //            if (k.GotKey)
                //                p.PositionYPlayer += 1;
                //            k.GotKey = false;
                //            k.AmountOfKeys = 0;
                //            break;
                //        }
                //        else
                //            p.PositionYPlayer += 1;
                //        m.Counter++;
                //        break;
                //}

                Console.Clear();
            } while (!(squares[p.PositionYPlayer, p.PositionXPlayer] is ExitRoom));


            x.PrintRoomInfo();
            x.PrintHighScore(p.Moves);

            Console.ReadKey();
        }
    }
}
