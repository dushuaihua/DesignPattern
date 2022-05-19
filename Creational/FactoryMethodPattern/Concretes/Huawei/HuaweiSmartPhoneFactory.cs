using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern.Concretes.Huawei;

public class HuaweiSmartPhoneFactory : ISmartPhoneFactory
{
    public SmartPhone CreateSmartPhone()
    {
        return new HuaweiSmartPhone();
    }
}
