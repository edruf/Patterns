namespace Patterns_FactoryMethod;

class Program
{
    public static void Main()
    {
            UIFactory formFactory = new WinFormFactory();
            UIComponent winForm = formFactory.CreateComponent();
            winForm.Render();

            UIFactory textFactory = new WinTextFactory();
            UIComponent winText = textFactory.CreateComponent();
            winText.Render();
        }
}


