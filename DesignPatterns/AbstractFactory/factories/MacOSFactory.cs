using DesignPatterns.AbstractFactory.buttons;
using DesignPatterns.AbstractFactory.checkboxes;

namespace DesignPatterns.AbstractFactory.factories;

public class MacOSFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacOSButton();
    }

    public ICheckbox CreateCheckBox()
    {
        return new MacOSCheckbox();
    }
}