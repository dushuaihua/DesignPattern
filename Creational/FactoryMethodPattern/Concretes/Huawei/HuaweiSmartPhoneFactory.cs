using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern.Concretes;

public class HuaweiSmartPhoneFactory : SmartPhoneFactory
{
    public override SmartPhone CreateSmartPhone()
    {
        return new HuaweiSmartPhone();
    }
}
