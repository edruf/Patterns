using Builder.Builders;
using Builder.Directors;
using Patterns_Builder.ComponentsOfBuilding;
using System.Data.SqlTypes;
using System.Text;
using System.Threading.Channels;

namespace Patterns_Builder;

class Program
{
    public static void Main()
    {
        DirectorFullButton directorFullButton = new DirectorFullButton();

        Console.WriteLine("--- Начало конструирования ---");

        Console.WriteLine("\n[РАБОТА №1: Простая текстовая кнопка (TextButtonBuilder)]");

        var textBuilder = new TextButtonBuilder();

        directorFullButton.Builder = textBuilder;

        directorFullButton.BuildFullButton();

        StringBuilder simpleButtonInfo = textBuilder.GetInfo();

        Console.WriteLine("\n[РАБОТА №2: Кнопка с минимальным набором свойств (ButtonBuilder)]");

        DirectorMinimalButton directorMinimalButton = new DirectorMinimalButton();

        var buttonBuilder = new ButtonBuilder();

        directorMinimalButton.Builder = buttonBuilder;

        directorMinimalButton.BuildMinimalButton();

        Button fullButton = buttonBuilder.GetButton();
    }
}

