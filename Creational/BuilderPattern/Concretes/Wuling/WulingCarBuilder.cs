namespace BuilderPattern.Concretes;

public class WulingCarBuilder : ICarBuilder
{
    private readonly WulingCar _wuling;

    public WulingCarBuilder()
    {
        _wuling = new WulingCar();
    }

    public void BuildBody()
    {
        _wuling.Body = new WulingBody();
        Console.WriteLine("Build wuling car body...");
    }

    public void BuildChassis()
    {
        _wuling.Chassis = new WulingChassis();
        Console.WriteLine("Build wuling car chassis...");
    }

    public void BuildEngine()
    {
        _wuling.Engine = new WulingEngine();
        Console.WriteLine("Build wuling car engine...");
    }

    public void BuildWheel()
    {
        _wuling.Wheel = new WulingWheel();
        Console.WriteLine("Build wuling car wheel...");
    }

    public Car GetCar()
    {
        return _wuling;
    }
}