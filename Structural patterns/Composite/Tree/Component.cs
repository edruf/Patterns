using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Composite.Tree
{
    internal abstract class Node 
    {
        public int _value;

        public Node(int value)
        {
            _value = value;
        }

        public abstract void Display();
    }
}
