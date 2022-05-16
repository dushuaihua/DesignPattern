ICarBuilder carBuilder = new HongqiCarBuilder();
var hongqiCar = new Workshop(carBuilder).BuildCar();
Console.WriteLine(hongqiCar);

carBuilder = new WulingCarBuilder();
var wulingCar = new Workshop(carBuilder).BuildCar();
Console.WriteLine(wulingCar);