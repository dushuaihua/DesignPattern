namespace BuilderPattern.Concretes;

public class HongqiCar : Car
{
    public override Engine Engine { get; set; }
    public override Body Body { get; set; }
    public override Chassis Chassis { get; set; }
    public override Wheel Wheel { get; set; }
}