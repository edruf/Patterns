using Builder;
using Builder.Builders;
using Patterns_Builder.ComponentsOfBuilding;
using System.Data.SqlTypes;
using System.Text;
using System.Threading.Channels;

namespace Patterns_Builder;

class Program
{
    public static void Main()
    {
        Director director = new Director();

        Console.WriteLine("--- Начало конструирования ---");

        Console.WriteLine("\n[РАБОТА №1: Простая текстовая кнопка (TextButtonBuilder)]");

        var textBuilder = new TextButtonBuilder();

        director.Builder = textBuilder;

        director.BuildFullButton();

        StringBuilder simpleButtonInfo = textBuilder.GetInfo();

        Console.WriteLine("\n[РАБОТА №2: Кнопка с полным набором свойств (ButtonBuilder)]");

        var buttonBuilder = new ButtonBuilder();

        director.Builder = buttonBuilder;

        director.BuildFullButton();

        Button fullButton = buttonBuilder.GetButton();
    }
}

