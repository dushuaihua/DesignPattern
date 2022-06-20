using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern.Concretes;

public class HuaweiSmartPhone : SmartPhone
{
    public override void TurnOn()
    {
        Console.WriteLine("Huawei smart phone turn on...");
    }
    public override void Working()
    {
        Console.WriteLine("Huawei smart phone working...");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Huawei smart phone turn off...");
    }
}
