ICarBuilder builder = new HongqiCarBuilder();
var workshop = new Workshop(builder);
workshop.BuildCar();
var hongqiCar = workshop.GetCar();
Console.WriteLine(hongqiCar);