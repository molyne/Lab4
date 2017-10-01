﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class RoomWithKey : Square ,  IRoomInfo
    {

        private bool gotKey = false;
        private int amountOfKeys = 0;

        public bool GotKey
        {
            get { return gotKey; }
            set { gotKey = value; }
        }
        public int AmountOfKeys
        {
            get { return amountOfKeys; }
            set { amountOfKeys = value; }
        }

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

