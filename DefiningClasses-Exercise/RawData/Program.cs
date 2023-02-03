using RawData;

int runs = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();
for (int i = 0; i < runs; i++)
    {
    string[] runInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string model = runInfo[0];
    int engineSpeed = int.Parse(runInfo[1]);
    int enginePower = int.Parse(runInfo[2]);
    int cargoWeight = int.Parse(runInfo[3]);
    string cargoType = runInfo[4];


    Car car = new Car();

    car.Model = model;

    Engine engine = new Engine(enginePower, enginePower);
    car.Engine = engine;

    Cargo cargo = new Cargo(cargoType, cargoWeight);
    car.Cargo = cargo;

    Tyre[] tires = new Tyre[4]
        {
                    new Tyre(int.Parse(runInfo[6]), double.Parse(runInfo[5])),
                    new Tyre(int.Parse(runInfo[8]), double.Parse(runInfo[7])),
                    new Tyre(int.Parse(runInfo[10]), double.Parse(runInfo[9])),
                    new Tyre(int.Parse(runInfo[12]), double.Parse(runInfo[11])),
        };
    car.Tyre = tires;
    cars.Add(car);
    }

string command = Console.ReadLine();
string[] filteredCarModels;
if (command == "fragile")
    {
    filteredCarModels = cars
    .Where(c => c.Cargo.Type == "fragile" && c.Tyre.Any(t => t.Presure < 1))
    .Select(c => c.Model)
    .ToArray();
    }
else
    {
    filteredCarModels = cars
    .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
    .Select(c => c.Model)
    .ToArray();
    }
Console.WriteLine(string.Join(Environment.NewLine,  filteredCarModels));
