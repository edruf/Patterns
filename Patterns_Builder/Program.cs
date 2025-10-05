namespace Patterns_Builder;

class Program
{
    public static void Main()
    {
        ButtonBuilder builder = new ButtonBuilder();
        UIClient client = new UIClient(builder);
        client.GetButtonWithIcon("иконка");
    }
}

