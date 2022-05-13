namespace AbstractFactoryPattern.Abstracts;

public interface IPeripheralFactory
{
    Mouse CreateMouse();
    Keyboard CreateKeyboard();
}
