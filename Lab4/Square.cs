using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameFromHell
{
    public abstract class Square 
    {
        protected int numberOfMoves;

        protected bool enterMonsterRoom = false;
        protected bool enterEmptyRoom = false;
        protected bool enterRoomWithKey = false;
 

        public bool EnterMonsterRoom
        {
            get { return enterMonsterRoom; }
            set { enterMonsterRoom = value; }
        }
        public bool EnterEmptyRoom
        {
            get { return enterEmptyRoom; }
            set { enterEmptyRoom = value; }
        }

        public bool EnterRoomWithKey
        {
            get { return enterRoomWithKey; }
            set { enterRoomWithKey = value; }
        }

        public int NumberOfMoves
        {
            get { return numberOfMoves; }
            set { numberOfMoves = value; }
        }

        public abstract string PrintSymbol();
       

        
    }
}
