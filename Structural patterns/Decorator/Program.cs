namespace Decorator;
class Program 
{ 
    public static void Main() 
    { 
        IButton button = new WinButton();
        IButton decoratedButton = new LoggerDecorator(button);
        decoratedButton.OnClick(); 
        decoratedButton.OnDoubleClick();
    }
}