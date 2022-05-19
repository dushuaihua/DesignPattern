using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern.Concretes.Xiaomi;

public class XiaomiSmartPhoneFactory : ISmartPhoneFactory
{
    public SmartPhone CreateSmartPhone()
    {
        return new XiaomiSmartPhone();
    }
}
