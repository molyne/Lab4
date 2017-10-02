using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Player 
    {
       private int positionXPlayer = 1; //spelarens position
       private int positionYPlayer = 1; //spelaren position
       private int moves = 0;

        public int PositionXPlayer
        {
            get { return positionXPlayer; }
            set { positionXPlayer = value; }
        }
        public int PositionYPlayer
        {
            get { return positionYPlayer; }
            set { positionYPlayer = value; }
        }
        public int Moves
        {
            get { return moves; }
            set { moves = value; }
        }

        public string PrintSymbol()
        {
            return "@";
        }

        RoomWithKey k = new RoomWithKey();

       public void Rotation(Square[,] squares,  int counter, bool gotKey, int amountOfKeys )
        {
            ConsoleKeyInfo move = Console.ReadKey();

            switch (move.Key) //lägg till hinder här också och dörrar och tomma rum. I en metod typ ispossible to move?
            {
                case ConsoleKey.D:
                    {
                        if (squares[positionYPlayer, positionXPlayer + 1] is Wall)

                            break;
                        if (squares[positionYPlayer, positionXPlayer + 1] is Door)

                        {
                            if (gotKey)
                                positionXPlayer += 1;
                            gotKey = false;
                            amountOfKeys = 0;
                           
                            break;
                        }
                        
                        else
                            positionXPlayer += 1;
                        moves++;
                        break;
                    }

                case ConsoleKey.A:

                    {
                        if (squares[positionYPlayer, positionXPlayer - 1] is Wall)

                            break;

                        else
                            positionXPlayer -= 1;
                        moves++;
                    }
                    break;

                case ConsoleKey.W:

                    if (squares[positionYPlayer - 1, positionXPlayer] is Wall)
                    {
                        break;
                    }

                    if (squares[positionYPlayer + -1, positionXPlayer] is Door)

                    {
                        if (gotKey)
                            positionYPlayer -= 1;
                        gotKey = false;
                        amountOfKeys = 0;
                        break;
                    }


                    else
                        positionYPlayer -= 1;
                    moves++;
                    break;

                case ConsoleKey.S:

                    if (squares[positionYPlayer + 1, positionXPlayer] is Wall)

                        break;
                    if (squares[positionYPlayer + 1, positionXPlayer] is Door)

                    {
                        if (gotKey)
                            positionYPlayer += 1;
                        gotKey = false;
                        amountOfKeys = 0;
                        break;
                    }
                    else
                        positionYPlayer += 1;
                    moves++;
                    break;
            }
        }


        

    }
}








