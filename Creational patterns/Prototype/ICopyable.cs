﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Prototype
{
    internal interface ICopyable<T>
    {
        WinButton Copy();
    }
}
