using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern.Concretes.Logitech;

public class LogitechMouse : Mouse
{
    public LogitechMouse()
    {
        Console.WriteLine("Logitech mouse init...");
    }
    public override void Click()
    {
        Console.WriteLine("Logitech mouse click");
    }

    public override void Move()
    {
        Console.WriteLine("Logitech mouse move");
    }
}
