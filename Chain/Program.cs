using Chain;
using Chain.Handlers;

class Program
{
    static void Main()
    {
        Handler blockHandler = new BlockHandler();
        Handler clickHandler = new ClickHandler();
        blockHandler.setNext(clickHandler);
        Button button = new Button(blockHandler);
        button.OnClick();
        button.Block();
        button.OnClick();
    }
}