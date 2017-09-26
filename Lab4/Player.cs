//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Lab4
//{
//    class Player : Squares
//    {
//        int positionXPlayer = 3; //spelarens position
//        int positionYPlayer = 2; //spelaren position




//        public void printPlayer()
//        {
//            if (positionXPlayer == Row && positionYPlayer == Column)
//            {
//                squares[Column, Row] = "@";
//            }
//        }

//        public void movePlayer()
//        {
//            ConsoleKeyInfo move = Console.ReadKey();
//            switch (move.Key)
//            {
//                case ConsoleKey.D:

//                    if (positionXPlayer < 11)
//                        positionXPlayer += 1; //går ett steg till höger
//                    break;
//                case ConsoleKey.A:
//                    if (positionXPlayer > 1)
//                        positionXPlayer -= 1; //går ett steg till vänster
//                    break;
//                case ConsoleKey.W:
//                    if (positionYPlayer > 1)
//                        positionYPlayer -= 1; //går uppåt ett steg
//                    break;
//                case ConsoleKey.S:
//                    if (positionYPlayer < 3)
//                        positionYPlayer += 1; //går neråt ett steg
//                    break;
//            }
        //}
//    }
//}
