namespace BuilderPattern.Concretes.Hongqi;

public class HongqiCarBuilder : ICarBuilder
{
    private readonly HongqiCar _hongqiCar;

    public HongqiCarBuilder()
    {
        _hongqiCar = new HongqiCar();
    }

    public void BuildBody()
    {
        _hongqiCar.Body = new HongqiBody();
        Console.WriteLine("Build hongqi car body...");
    }

    public void BuildChassis()
    {
        _hongqiCar.Chassis = new HongqiChassis();
        Console.WriteLine("Build hongqi car chassis...");
    }

    public void BuildEngine()
    {
        _hongqiCar.Engine = new HongqiEngine();
        Console.WriteLine("Build hongqi car engine...");
    }

    public void BuildWheel()
    {
        _hongqiCar.Wheel = new HongqiWheel();
        Console.WriteLine("Build hongqi car wheel...");
    }

    public Car GetCar()
    {
        return _hongqiCar;
    }
}