using AbstractFactoryPattern;
using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.Implementions;

IPeripheralFactory peripheralFactory = new DellPeripheralFactory();

var runner = new Runner(peripheralFactory);

runner.BuildPeripheral();
runner.UsePeripheral();

peripheralFactory = new LogitechPeripheralFactory();
runner = new Runner(peripheralFactory);
runner.BuildPeripheral();
runner.UsePeripheral();