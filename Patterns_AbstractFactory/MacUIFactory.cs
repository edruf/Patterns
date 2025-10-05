namespace Patterns_AbstractFactory;

internal class MacUIFactory : UIFactory
{
    protected override IButton CreateButton()
    {
        IButton button = new MacButton();
        return button;
    }
    protected override IInput CreateInput()
    {
        IInput input = new MacInput();
        return input;
    }
}