namespace DesignPatterns.AbstractFactory.buttons;

public class MacOSButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("You have created MacOSButton.");
    }
}