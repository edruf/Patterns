using Patterns_FactoryMethod.UIComponents;
using Patterns_FactoryMethod.UIFactories;

namespace Patterns_FactoryMethod;

class Program
{
    public static void Main()
    {
        try
        {
            UIFactory formFactory = new WinFormFactory();
            UIComponent winForm = formFactory.CreateComponent();
            winForm.Render();

            UIFactory textFactory = new WinTextFactory();
            UIComponent winText = textFactory.CreateComponent();
            winText.Render();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


