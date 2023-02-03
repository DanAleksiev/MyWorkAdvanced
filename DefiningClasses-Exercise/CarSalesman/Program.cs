using RawData;
using System.Drawing;

int numOfEngines = int.Parse(Console.ReadLine());
List<Engine> engines = new List<Engine>();
for (int i = 0; i < numOfEngines; i++)
    {
    string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
    string model = input[0];
    int power = int.Parse(input[1]);

    Engine engine = new Engine();
    engine.Model = model;
    engine.Power = power;
    if (input.Length >= 3)
        {
        if (int.TryParse(input[2], out power))
            {
            int displacement = int.Parse(input[2]);
            engine.Displacement = displacement;
            }
        else
            {
            string efficiency = input[2];
            engine.Efficiency = efficiency;
            }
        }
    if (input.Length == 4)
        {
        string efficiency = input[3];
        engine.Efficiency = efficiency;
        }

    engines.Add(engine);
    }

int numberCars = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();
for (int i = 0; i < numberCars; i++)
    {
    string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

    Car car = new Car();
    string model = input[0];
    car.Model = model;
    string engine = input[1];

    foreach (var currentEngine in engines)
        {
        if (engine == currentEngine.Model)
            {
            car.Engine = currentEngine;
            }
        }

    if (input.Length >= 3)
        {

        if (int.TryParse(input[2], out int resoult))
            {
            int weight = int.Parse(input[2]);
            car.Weight = weight;
            }
        else
            {
            string colour = input[2];
            car.Colour = colour;
            }
        }
    if (input.Length == 4)
        {
        string colour = input[3];
        car.Colour = colour;
        }

    cars.Add(car);
    }

foreach (var car in cars)
    {
    string dis = "n/a";
    string wei = "n/a";
    if (car.Engine.Displacement > 0)
        {
        dis = car.Engine.Displacement.ToString();
        }
    if (car.Weight > 0)
        {
        wei = car.Weight.ToString();
        }
    Console.WriteLine($"{car.Model}:\n  {car.Engine.Model}:\n    Power: {car.Engine.Power}\n    Displacement: {dis}\n    Efficiency: {car.Engine.Efficiency}\n  Weight: {wei}\n  Color: {car.Colour}");
    }
