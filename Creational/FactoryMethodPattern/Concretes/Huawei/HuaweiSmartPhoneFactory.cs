using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern.Concretes;

public class HuaweiSmartPhoneFactory : ISmartPhoneFactory
{
    public SmartPhone CreateSmartPhone()
    {
        return new HuaweiSmartPhone();
    }
}
