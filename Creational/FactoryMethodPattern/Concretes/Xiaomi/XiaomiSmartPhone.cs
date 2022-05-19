using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern.Concretes.Xiaomi;

public class XiaomiSmartPhone : SmartPhone
{
    public override void TurnOn()
    {
        Console.WriteLine("Xiaomi smart phone turn on...");
    }
    public override void Working()
    {
        Console.WriteLine("Xiaomi smart phone woring...");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Xiaomi smart phone turn off...");
    }

}
