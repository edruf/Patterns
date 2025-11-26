using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Tree
{
    internal class Branch : Node
    {
        private List<Node> _children = new List<Node>();
        public Branch(int value) : base(value) { }
        public void AddChild(Node child)
        {
            _children.Add(child);
        }

        public List<Node> GetChildren()
        {
            return _children;
        }

        public override void Display()
        {
            Console.WriteLine(new string('-', _value) + " Branch with value: " + _value);
            foreach (var child in _children)
            {
                child.Display();
            }
        }
    }
}
