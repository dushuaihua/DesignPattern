using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern.Concretes;

public class XiaomiSmartPhoneFactory : SmartPhoneFactory
{
    public override SmartPhone CreateSmartPhone()
    {
        return new XiaomiSmartPhone();
    }
}
