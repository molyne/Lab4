using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameFromHell
{
    class RoomWithKey : Square ,  IRoomInfo
    {

        private bool gotKey = false;
        private int numberOfKeys = 0;

        public bool GotKey
        {
            get { return gotKey; }
            set { gotKey = value; }
        }
        public int NumberofKeys
        {
            get { return numberOfKeys; }
            set { numberOfKeys = value; }
        }

        public void PrintRoomInfo()
        {
            Console.WriteLine("You got a key");
            

        }

        public override string PrintSymbol()
        {
            return "k";
        }

        public void BeenInRoomWithKey() //metod som kollar om spelaren har gått över nyckel symbolen.
        {
            if (enterRoomWithKey) //om man har gått över nyckelsymbolen får man en nyckel.
            {
               
                PrintRoomInfo();

                enterRoomWithKey = false;
                gotKey = true;

            }
        }

       
    }
}

