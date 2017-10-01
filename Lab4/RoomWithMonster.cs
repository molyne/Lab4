using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class RoomWithMonster : Square, IPrintSymbol, IRoomInfo
    {

            

        public void PrintRoomInfo()
        {
            Console.WriteLine("U entered a room with a Monster and he slowed you down so now you walked 23 extra steps.");

        }

        public override string PrintSymbol()
        {
            return "m";
        }


        public void CheckRoom()
        {

            if (enterMonsterRoom)
            {

                PrintRoomInfo();

                counter += 23;

                enterMonsterRoom = false;
            }
        }


}
}

