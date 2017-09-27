using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Wall : Squares, IPrintSymbol
    {
       

        public char PrintSymbol()
        {
            return '#';
        }



    }
}
