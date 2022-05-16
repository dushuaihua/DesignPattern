namespace BuilderPattern.Abstracts;

public interface ICarBuilder
{
    void BuildEngine();
    void BuildBody();
    void BuildChassis();
    void BuildWheel();
    Car GetCar();
}