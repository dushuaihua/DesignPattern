namespace BuilderPattern;

public class Workshop
{
    private ICarBuilder _carBuilder;

    public Workshop(ICarBuilder carBuilder)
    {
        _carBuilder = carBuilder;
    }

    public void BuildCar()
    {
        _carBuilder.BuildEngine();
        _carBuilder.BuildBody();
        _carBuilder.BuildChassis();

        for (int i = 0; i < 4; i++)
        {
            _carBuilder.BuildWheel();
        }
    }

    public Car GetCar()
    {
        return _carBuilder.GetCar();
    }
}