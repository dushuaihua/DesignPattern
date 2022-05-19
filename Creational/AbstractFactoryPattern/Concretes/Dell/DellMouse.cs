using AbstractFactoryPattern.Abstracts;

namespace AbstractFactoryPattern.Concretes.Dell;

public class DellMouse : Mouse
{
    public DellMouse()
    {
        Console.WriteLine("Dell mouse init...");
    }
    public override void Click()
    {
        Console.WriteLine("Dell mouse click");
    }

    public override void Move()
    {
        Console.WriteLine("Dell mouse move");
    }
}
