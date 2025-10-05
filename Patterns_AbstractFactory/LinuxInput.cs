namespace Patterns_AbstractFactory;

internal class LinuxInput : IInput
{
    public void InputText()
    {
        Console.WriteLine("Вводим текст на Linux");
    }
    public void Focus()
    {
        Console.WriteLine("Мы внутри Linux строчки");
    }
}