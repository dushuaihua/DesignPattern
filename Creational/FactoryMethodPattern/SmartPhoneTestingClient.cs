using FactoryMethodPattern.Abstracts;

namespace FactoryMethodPattern;

public class SmartPhoneTestingClient
{
    private SmartPhone _smartPhone;
    public void BuildTestingContext(ISmartPhoneFactory factory)
    {
        _smartPhone = factory.CreateSmartPhone();
    }
    public void TestingSmartPhone()
    {
        _smartPhone.TurnOn();
        _smartPhone.Working();
        _smartPhone.TurnOff();
    }
}
