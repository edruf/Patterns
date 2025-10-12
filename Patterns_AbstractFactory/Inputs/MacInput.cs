namespace Patterns_AbstractFactory.Inputs;

internal class MacInput : IInput
{
    public void InputText()
    {
        Console.WriteLine("Вводим текст на Mac");
    }
    public void Focus()
    {
        Console.WriteLine("Мы внутри Mac строчки");
    }
}