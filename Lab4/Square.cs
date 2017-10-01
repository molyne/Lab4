using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public abstract class Square : IPrintSymbol
    {
        protected int counter;

        protected bool enterMonsterRoom = false;
        protected bool enterEmptyRoom = false;
        protected bool enterRoomWithKey = false;
        //protected bool gotKey = false;

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
        //public bool GotKey
        //{
        //    get { return gotKey; }
        //    set { gotKey = value; }
        //}


        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }



        public virtual string PrintSymbol()
        {
            return "x";
        }
    }
}
