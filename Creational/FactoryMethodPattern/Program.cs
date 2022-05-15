using FactoryMethodPattern;
using FactoryMethodPattern.Concretes;

var xiamomiSmartPhoneFactory = new XiaomiSmartPhoneFactory();

var client = new SmartPhoneTestingClient();
client.BuildTestingContext(xiamomiSmartPhoneFactory);
client.TestingSmartPhone();

var huaweiSmartPhoneFactory = new HuaweiSmartPhoneFactory();

client.BuildTestingContext(huaweiSmartPhoneFactory);
client.TestingSmartPhone();
