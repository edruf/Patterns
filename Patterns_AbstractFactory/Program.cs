namespace Patterns_AbstractFactory;
using PatternsClassLibrary;

internal class Program
{
    public static void Main()
    {
        UIFactory factory = new WinUIFactory();
        IButton button = factory.GetButton(); // Используем публичный метод
        button.OnClick();
        button.OnDoubleClick();
        IInput input = factory.GetInput(); // Используем публичный метод
        input.InputText();
        input.Focus();

        factory = new MacUIFactory();
        button = factory.GetButton();
        button.OnClick();
        button.OnDoubleClick();
        input = factory.GetInput();
        input.InputText();
        input.Focus();

        factory = new LinuxUIFactory();
        button = factory.GetButton();
        button.OnClick();
        button.OnDoubleClick();
        input = factory.GetInput();
        input.InputText();
        input.Focus();
    }
}