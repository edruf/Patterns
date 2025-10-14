using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal interface IButton
    {
        void OnClick();
        void OnDoubleClick();
    }
}
