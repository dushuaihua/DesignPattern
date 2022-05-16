namespace BuilderPattern.Abstracts;

public abstract class Car
{
    public abstract Engine Engine { get; set; }
    public abstract Body Body { get; set; }
    public abstract Chassis Chassis { get; set; }
    public abstract Wheel Wheel { get; set; }
}