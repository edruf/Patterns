namespace Decorator;
class Program 
{ 
    public static void Main() 
    { 
        IButton button = new WinButton();
        IButton decoratedButton = new AllowDecorator(button, UserRole.User);
        decoratedButton.OnClick(); 
        decoratedButton.OnDoubleClick();
    }
}