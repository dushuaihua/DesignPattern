using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern.Concretes.Dell;

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
