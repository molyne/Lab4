using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class RoomWithMonster : Square,  IRoomInfo
    {

            

        public void PrintRoomInfo()
        {
            Console.WriteLine("U entered a room with a Monster and he slowed you down so now you walked 23 extra steps.");

        }

        public override string PrintSymbol()
        {
            return "m";
        }


        public void CheckRoom(int moves)
        {

            if (enterMonsterRoom)
            {

                PrintRoomInfo();

                moves += 23;

                enterMonsterRoom = false;
            }
        }


}
}

