using Chain;
using Chain.Handlers;

class Program
{
    static void Main()
    {
        Handler clickHandler = new ClickHandler(null);
        Handler blockHandler = new BlockHandler(clickHandler);
        Button button = new Button(blockHandler);
        button.OnClick();
        button.Block();
        button.OnClick();
    }
}