using SpeedRacing;

int numberOfCars = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();
for (int i = 0; i < numberOfCars; i++)
    {
    string inputCar = Console.ReadLine();
    List<string> carSpecifics = inputCar.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

    Car car = new Car();
    car.Model = carSpecifics[0];
    car.FuelAmount = double.Parse(carSpecifics[1]);
    car.FuelConsumptionPerKilometer = double.Parse(carSpecifics[2]);
    cars.Add(car);
    }
string input;
while ((input = Console.ReadLine()) != "End")
    {
    string[] driveCar = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string model = driveCar[1];
    double distance = double.Parse(driveCar[2]);

    foreach (var car in cars)
        {
        if (car.Model == model)
            {
            car.CanTheCarGoThatFar(distance);
            }
        }
    }

foreach (Car car in cars)
    {
    car.WhoAmI();
    }