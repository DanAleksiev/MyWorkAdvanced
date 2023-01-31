
namespace CarManufacturer
    {
    public class StartUp
        {
        static void Main()
            {
            string input;

            List<Tire[]> ListOfTires = new List<Tire[]>();
            while ((input = Console.ReadLine()) != "No more tires")
                {
                string[] eachTire = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Tire[] tires = new Tire[4]
                    {
                    new Tire(int.Parse(eachTire[0]), double.Parse(eachTire[1])),
                    new Tire(int.Parse(eachTire[2]), double.Parse(eachTire[3])),
                    new Tire(int.Parse(eachTire[4]), double.Parse(eachTire[5])),
                    new Tire(int.Parse(eachTire[6]), double.Parse(eachTire[7])),
                    };
                ListOfTires.Add(tires);
                }

            List<Engine> engines = new List<Engine>();
            while ((input = Console.ReadLine()) != "Engines done")
                {
                string[] splitEngine = input.Split();
                int horsePower = int.Parse(splitEngine[0]);
                double cC = double.Parse(splitEngine[1]);
                Engine engine = new Engine(horsePower, cC);
                engines.Add(engine);
                }
            List<Car> specialCars = new List<Car>();
            while ((input = Console.ReadLine()) != "Show special")
                {
                string[] splitCompleateCar = input.Split(" ");

                Car car = new Car();
                car.Make = splitCompleateCar[0];
                car.Model = splitCompleateCar[1];
                car.Year = int.Parse(splitCompleateCar[2]);
                car.FuelQuantity = int.Parse(splitCompleateCar[3]);
                car.FuelConsumption = double.Parse(splitCompleateCar[4])/5;

                int engineIndex = int.Parse(splitCompleateCar[5]);
                int tireIndex = int.Parse(splitCompleateCar[6]);
                car.Engine = engines[engineIndex];
                car.Tires = ListOfTires[tireIndex];
                specialCars.Add(car);
                }

            foreach (Car car in specialCars)
                {
                double tireSum = 0;
                foreach (var tire in car.Tires)
                    {
                    tireSum += tire.Pressure;
                    }

                if (car.Year >= 2017 && car.Engine.HorsePower >= 330 && tireSum >= 9 && tireSum <= 10)
                    {
                    car.Drive(20);

                    Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity} ");
                    }
                }

            }
        }
    }