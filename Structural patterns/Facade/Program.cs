using Facade;
using System.Text;
namespace Patterns_Builder.ComponentsOfBuilding;
class Program
{
    static void Main()
    {
        BuilderFacade builderFacade = new BuilderFacade();
        Console.WriteLine("----------FULL BUTTON----------");
        Button fullButton = builderFacade.CreateFullButton();
        Console.WriteLine("----------MINIMAL BUTTON----------");
        Button minimalButton = builderFacade.CreateMinimalButton();
        Console.WriteLine("----------CANCEL BUTTON----------");
        Button cancelButton = builderFacade.CreateCancelButton();
        Console.WriteLine("----------TEXT BUTTON INFO----------");
        StringBuilder fullButtonInfo = builderFacade.CreateTextFullButtonInfo();
        StringBuilder minimalButtonInfo = builderFacade.CreateTextMinimalButtonInfo();
        StringBuilder cancelButtonInfo = builderFacade.CreateTextCancelButtonInfo();

    }
}   
