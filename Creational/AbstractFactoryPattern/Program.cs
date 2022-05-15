using AbstractFactoryPattern;
using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.Concretes;

IPeripheralFactory peripheralFactory = new DellPeripheralFactory();

var client = new Client(peripheralFactory);

client.BuildPeripheral();
client.UsePeripheral();

peripheralFactory = new LogitechPeripheralFactory();
client = new Client(peripheralFactory);
client.BuildPeripheral();
client.UsePeripheral();