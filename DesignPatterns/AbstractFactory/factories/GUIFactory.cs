using DesignPatterns.AbstractFactory.buttons;
using DesignPatterns.AbstractFactory.checkboxes;

namespace DesignPatterns.AbstractFactory.factories

{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckBox();
    }
}