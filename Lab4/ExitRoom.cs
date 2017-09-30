using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class ExitRoom : Square , IPrintSymbol, IRoomInfo
    {
        public void PrintRoomInfo()
        {
            Console.WriteLine("U walked out of the game");
        }

        public override string PrintSymbol()
        {
            return "X";
        }

        

     

    }
}
