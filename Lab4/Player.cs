using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameFromHell
{
    class Player
    {
        private int positionXPlayer = 1; //spelarens position
        private int positionYPlayer = 1; //spelarens position

        public int PositionXPlayer
        {
            get { return positionXPlayer; }
            set { positionXPlayer = value; }
        }
        public int PositionYPlayer
        {
            get { return positionYPlayer; }
            set { positionYPlayer = value; }
        }

        public string PrintSymbol()
        {
            return "@";
        }
    }

}
       