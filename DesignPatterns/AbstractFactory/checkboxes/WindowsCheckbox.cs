namespace DesignPatterns.AbstractFactory.checkboxes;

public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("You have created WindowsCheckbox.");
    }
}