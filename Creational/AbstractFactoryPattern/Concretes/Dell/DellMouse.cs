namespace AbstractFactoryPattern.Concretes;

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
