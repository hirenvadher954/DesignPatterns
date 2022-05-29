using DesignPatterns.AbstractFactory.buttons;
using DesignPatterns.AbstractFactory.checkboxes;
using DesignPatterns.AbstractFactory.factories;

namespace DesignPatterns.AbstractFactory.app;

public class Application
{
    private readonly IButton? _button;
    private readonly ICheckbox? _checkbox;

    public Application(IGUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckBox();
    }
    
    public void Paint(){
        _button?.Paint();
        _checkbox?.Paint();
    }
    
}