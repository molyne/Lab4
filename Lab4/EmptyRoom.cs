using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class EmptyRoom : Square , IPrintSymbol, IRoomInfo
    {
        public void PrintRoomInfo()
        {
           
            Console.WriteLine("You entered a empty room");
        }

        public override string PrintSymbol()
        {
            return "e";
        }

    }
}
