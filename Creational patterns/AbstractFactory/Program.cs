namespace Patterns_AbstractFactory;
using Patterns_AbstractFactory.Buttons;
using Patterns_AbstractFactory.Factories;
using Patterns_AbstractFactory.Inputs;

internal class Program
{
    public static void Main()
    {
        UIFactory factory = new WinUIFactory();
        Buttons.IButton button = factory.CreateButton();
        button.OnClick();
        button.OnDoubleClick();
        IInput input = factory.CreateInput();
        input.InputText();
        input.Focus();

        factory = new MacUIFactory();
        button = factory.CreateButton();
        button.OnClick();
        button.OnDoubleClick();
        input = factory.CreateInput();
        input.InputText();
        input.Focus();

        factory = new LinuxUIFactory();
        button = factory.CreateButton();
        button.OnClick();
        button.OnDoubleClick();
        input = factory.CreateInput();
        input.InputText();
        input.Focus();
    }
}