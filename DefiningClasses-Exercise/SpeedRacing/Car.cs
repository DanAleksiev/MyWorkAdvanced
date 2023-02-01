namespace SpeedRacing
    {
    public class Car
        {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;
        public Car()
            {
            TravelledDistance = 0;
            }
        public string Model { get { return model; } set { model = value; } }
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { fuelConsumptionPerKilometer = value; } }
        public double TravelledDistance { get { return travelledDistance; } set { travelledDistance = value; } }

        public  void CanTheCarGoThatFar (double distance)
            {
            if (distance*this.fuelConsumptionPerKilometer <= this.fuelAmount) 
                {
                this.fuelAmount -= distance*this.fuelConsumptionPerKilometer;
                this.travelledDistance += distance;
                }
            else
                {
                Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        public void WhoAmI()
            {
            Console.WriteLine($"{this.Model} {this.fuelAmount:f2} {this.TravelledDistance}");
            }
        }
    }
