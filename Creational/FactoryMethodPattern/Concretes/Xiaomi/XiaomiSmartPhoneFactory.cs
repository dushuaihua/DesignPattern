using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern.Concretes;

public class XiaomiSmartPhoneFactory : ISmartPhoneFactory
{
    public SmartPhone CreateSmartPhone()
    {
        return new XiaomiSmartPhone();
    }
}
