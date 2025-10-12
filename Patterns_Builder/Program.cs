namespace Patterns_Builder;

class Program
{
    public static void Main()
    {
        try 
        {
            ButtonBuilder builder = new ButtonBuilder();
            UIClient client = new UIClient(builder);
            client.GetButtonWithIcon("иконка");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

