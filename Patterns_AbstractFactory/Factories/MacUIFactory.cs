using Patterns_AbstractFactory.Buttons;
using Patterns_AbstractFactory.Inputs;

namespace Patterns_AbstractFactory.Factories;

internal class MacUIFactory : UIFactory
{
    public IButton CreateButton()
    {
        IButton button = new MacButton();
        return button;
    }
    public IInput CreateInput()
    {
        IInput input = new MacInput();
        return input;
    }
}