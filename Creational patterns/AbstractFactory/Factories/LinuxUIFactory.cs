using Patterns_AbstractFactory.Buttons;
using Patterns_AbstractFactory.Inputs;

namespace Patterns_AbstractFactory.Factories;
internal class LinuxUIFactory : UIFactory
{
    public  IButton CreateButton()
    {
        IButton button = new LinuxButton();
        return button;
    }
    public IInput CreateInput()
    {
        IInput input = new LinuxInput();
        return input;
    }
}