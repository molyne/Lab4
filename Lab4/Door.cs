﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Door : Square , IPrintSymbol
    {
        public override string PrintSymbol()
        {
            return "D";
        }
    }

}
