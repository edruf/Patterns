using Composite.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Iterator
{
    internal class TreeIterator : IIterator
    {
        private Stack<Node> _stack = new Stack<Node>();

        public TreeIterator(Node root)
        {
            _stack.Push(root);
        }

        public bool HasNext() 
        { 
            return _stack.Count > 0;
        }

        public Node Next()
        {
            if (!HasNext()) 
            {
                return null;
            }
                
            Node current = _stack.Pop();
            if (current is Branch branch)
            {
                var children = branch.GetChildren();
                for (int i = children.Count - 1; i >= 0; i--)
                {
                    _stack.Push(children[i]);
                }
            }
            return current;
        }
    }
}
