using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public interface IMemento
    {
        string GetName();
        DateTime GetDate();
    }
}
