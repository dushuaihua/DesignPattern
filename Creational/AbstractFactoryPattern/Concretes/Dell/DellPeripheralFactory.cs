using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern.Concretes;

public class DellPeripheralFactory : IPeripheralFactory
{
    public Keyboard CreateKeyboard()
    {
        return new DellKeyboard();
    }

    public Mouse CreateMouse()
    {
        return new DellMouse();
    }
}
