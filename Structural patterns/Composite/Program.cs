using Composite;
using Composite.Iterator;
using Composite.Tree;

class Program
{
    static void Main()
    {
        Branch root = new Branch(1);
        Branch branch2 = new Branch(2);
        branch2.AddChild(new Leaf(3));
        branch2.AddChild(new Leaf(4));
        Branch branch3 = new Branch(5);
        branch2.AddChild(new Leaf(6));

        root.AddChild(branch2);
        root.AddChild(branch3);
        root.AddChild(new Leaf(7));

        IIterator iterator = new TreeIterator(root);

        while (iterator.HasNext())
        {
            Node item = iterator.Next();

            Console.Write($" -> {item._value}");
        }
        Console.WriteLine("\nГотово!");
    }
}