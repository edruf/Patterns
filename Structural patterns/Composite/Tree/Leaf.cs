using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Tree
{
    internal class Leaf : Node
    {
        public Leaf(int value) : base(value) { }
        public override void Display()
        {
            Console.WriteLine(new string('-', _value) + " Leaf with value: " + _value);
        }
    }
}
