using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameFromHell
{
    class EmptyRoom : Square , IRoomInfo
    {
        public void PrintRoomInfo()
        {
           
            Console.WriteLine("You entered a empty room");
        }

        public override string PrintSymbol()
        {
            return "e";
        }

        public void CheckRoom()
        {

            if (enterEmptyRoom)
            {
               

                PrintRoomInfo();

                enterEmptyRoom = false;
            }
        }

    }
}
