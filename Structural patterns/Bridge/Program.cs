using Bridge;
using Bridge.Buttons;
using Bridge.Renderers;

class Program 
{
    public static void Main()
    {
        try
        {
            IRenderer WinRenderer = new WindowsRenderer();
            Button WinRound = new RoundButton(WinRenderer);
            Button WinSquare = new SquareButton(WinRenderer);
            IRenderer MacRenderer = new MacRenderer();
            Button MacRound = new RoundButton(MacRenderer);
            Button MacSquare = new SquareButton(MacRenderer);

            WinRound.Draw();
            WinSquare.Draw();
            MacRound.Draw();
            MacSquare.Draw();

            WinRound = new RoundButton(MacRenderer);
            WinRound.Draw();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
        }
    }
}