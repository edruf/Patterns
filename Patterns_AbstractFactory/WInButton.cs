namespace Patterns_AbstractFactory;

internal class WinButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("Windows кнопка нажата");
    }
    public void OnDoubleClick()
    {
        Console.WriteLine("Windows кнопка нажата дважды");
    }
}