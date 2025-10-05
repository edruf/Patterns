namespace Patterns_AbstractFactory;
internal class LinuxUIFactory : UIFactory
{
    protected override IButton CreateButton()
    {
        IButton button = new LinuxButton();
        return button;
    }
    protected override IInput CreateInput()
    {
        IInput input = new LinuxInput();
        return input;
    }
}