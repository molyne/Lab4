using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class EmptyRoom: Square, IPrintSymbol
    {
        public override string PrintSymbol()
        {
            return "-"; 
        }

    }
}
