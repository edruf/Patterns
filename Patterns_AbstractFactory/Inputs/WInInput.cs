namespace Patterns_AbstractFactory.Inputs;

internal class WinInput : IInput
{
    public void InputText()
    {
        Console.WriteLine("Вводим текст на Windows");
    }
    public void Focus() 
    {
        Console.WriteLine("Мы внутри Windows строчки");
    }
}