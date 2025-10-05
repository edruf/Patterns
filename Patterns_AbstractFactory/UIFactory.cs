namespace Patterns_AbstractFactory;

internal abstract class UIFactory
{
    abstract protected IButton CreateButton();
    abstract protected IInput CreateInput();
    public IButton GetButton()
    {
        return CreateButton();
    }
    public IInput GetInput()
    {
        return CreateInput();
    }
}