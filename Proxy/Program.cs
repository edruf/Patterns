using Proxy;

class Program
{
    static void Main()
    {
        IButton button = new WinButton();
        IButton proxyButton = new IProxy(button, UserRole.User);
        proxyButton.OnClick();
        proxyButton.OnDoubleClick();
    }
}
