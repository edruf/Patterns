namespace Patterns_AbstractFactory;

internal class MacButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("Mac кнопка нажата");
    }
    public void OnDoubleClick()
    {
        Console.WriteLine("Mac кнопка нажата дважды");
    }
}