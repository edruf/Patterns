using Patterns_AbstractFactory.Buttons;
using Patterns_AbstractFactory.Inputs;

namespace Patterns_AbstractFactory.Factories;

public interface UIFactory
{
    internal IButton CreateButton();
    internal IInput CreateInput();
}