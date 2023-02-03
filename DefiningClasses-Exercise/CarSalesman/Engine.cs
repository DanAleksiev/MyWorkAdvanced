namespace RawData
    {
    public class Engine
        {
        private int power;
        private string model;
        private string efficiency;
        private int displacement;
        public Engine()
            {
            Efficiency = "n/a";
            displacement = 0;
            }
        public Engine(int power, string model, string efficiency, int displacement) : this()
            {
            Power = power;
            Model = model;
            Efficiency = efficiency;
            Displacement = displacement;
            }

        public string Model { get { return model; } set { model = value; } }
        public int Displacement { get { return displacement; } set { displacement = value; } }
        public string Efficiency { get { return efficiency; } set { efficiency = value; } }
        public int Power { get { return power; } set { power = value; } }
        }
    }
