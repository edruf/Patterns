using Composite.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Iterator
{
    internal interface IIterator
    {
        bool HasNext();
        Node Next();
    }
}
