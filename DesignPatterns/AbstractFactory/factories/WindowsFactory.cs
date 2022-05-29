using DesignPatterns.AbstractFactory.buttons;
using DesignPatterns.AbstractFactory.checkboxes;

namespace DesignPatterns.AbstractFactory.factories;

public class WindowsFactory:IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckBox()
    {
        return new WindowsCheckbox();
    }
}