using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class RoomWithKey : Square , IPrintSymbol, IRoomInfo
    {
        public void PrintRoomInfo()
        {
            Console.WriteLine("You got a key");
            

        }

        public override string PrintSymbol()
        {
            return "k";
        }

        public void CheckRoom()
        {
            if (enterRoomWithKey)
            {
               
                PrintRoomInfo();

                enterRoomWithKey = false;
                gotKey = true;

            }
        }
    }
}

