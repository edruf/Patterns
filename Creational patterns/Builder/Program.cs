using Builder;
using System.Data.SqlTypes;

namespace Patterns_Builder;

class Program
{
    public static void Main()
    {
        try 
        {
            //ButtonBuilder builder = new ButtonBuilder();
            //UIClient client = new UIClient(builder);
            //client.GetButtonWithIcon("иконка");
            //IBuilder buttonBuilder = new ButtonBuilder();
            //Director director = new Director();
            //director.Builder = buttonBuilder;
            //director.BuildMinimalButton("некий текст");
            //buttonBuilder = new TextButtonBuilder();
            //Director director1 = new Director();
            //director1.Builder = buttonBuilder;
            //director1.BuildMinimalButton("другой текст");
            var director = new Director();
            var buttonBuilder = new ButtonBuilder();
            director.Builder = buttonBuilder;
            director.BuildMinimalButton("text");
            Console.WriteLine(buttonBuilder.GetButton());

            var textButtonBuilder = new TextButtonBuilder();
            director.Builder = textButtonBuilder;
            director.BuildMinimalButton("text");
            Console.WriteLine(textButtonBuilder.GetInfo());


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

