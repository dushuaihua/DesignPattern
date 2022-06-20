using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern.Concretes;

public class LogitechKeyboard : Keyboard
{
    public LogitechKeyboard()
    {
        Console.WriteLine("Logitech keyboard init...");
    }
    public override void Input()
    {
        Console.WriteLine("Logitech keyboard input");
    }
}
