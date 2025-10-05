namespace Patterns_AbstractFactory;

internal class WinUIFactory : UIFactory
{
    protected override IButton CreateButton() 
    {
        IButton button = new WinButton();
        return button;
    }
    protected override IInput CreateInput()
    {
        IInput input = new WinInput();
        return input;
    }
}