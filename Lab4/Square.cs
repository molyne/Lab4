using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public abstract class Square : IPrintSymbol
    {
        public virtual string PrintSymbol()
        {
            return "x";
        }
    }
}
