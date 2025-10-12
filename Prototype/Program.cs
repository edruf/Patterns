namespace Patterns_Prototype;
class Client
{
    static void Main()
    {
        Console.WriteLine("Original:");
        WinButton originalButton = new WinButton("one", "blue");
        originalButton.OnClick();
        originalButton.OnDoubleClick();
        Console.WriteLine(originalButton.ToString());
        Console.WriteLine("=======================");
        Console.WriteLine("Clone:");
        WinButton cloneButton =  originalButton.Copy();
        cloneButton.OnClick();
        cloneButton.OnDoubleClick();
        Console.WriteLine(cloneButton.ToString());
    }
}