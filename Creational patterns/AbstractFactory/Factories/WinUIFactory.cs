using Patterns_AbstractFactory.Buttons;
using Patterns_AbstractFactory.Inputs;

namespace Patterns_AbstractFactory.Factories;

internal class WinUIFactory : UIFactory
{
    public IButton CreateButton() 
    {
        IButton button = new WinButton();
        return button;
    }
    public IInput CreateInput()
    {
        IInput input = new WinInput();
        return input;
    }
}