namespace DesignPatterns.AbstractFactory.buttons;

public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("You have created Windows button");
    }
}