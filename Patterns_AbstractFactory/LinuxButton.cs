namespace Patterns_AbstractFactory;

internal class LinuxButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("Linux кнопка нажата");
    }
    public void OnDoubleClick()
    {
        Console.WriteLine("Linux кнопка нажата дважды");
    }
}
