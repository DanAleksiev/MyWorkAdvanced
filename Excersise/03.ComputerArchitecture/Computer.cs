using System.Text;

namespace ComputerArchitecture
    {
    public class Computer
        {
        public Computer(string model, int capacity)
            {
            Capacity = capacity;
            Model = model;
            Multiprocessor = new List<CPU>();
            }

        public List<CPU> Multiprocessor { get; set; }
        public int Capacity { get; set; }
        public string Model { get; set; }
        public int Count { get; set; }



        public void Add(CPU cpu)
            {
            if (Multiprocessor.Count < Capacity)
                {
                Multiprocessor.Add(cpu);
                Count++;
                }
            }

        public bool Remove(string brand)
            {
            foreach (CPU cpu in Multiprocessor)
                {
                if (cpu.Brand == brand)
                    {
                    Count--;
                    Multiprocessor.Remove(cpu);
                    return true;
                    }
                }
            return false;
            }

        public CPU MostPowerful()
            {
            CPU mostPowerful = null;
            foreach (CPU cpu in Multiprocessor)
                {
                if (mostPowerful == null)
                    {
                    mostPowerful = cpu;
                    }
                int result = cpu.Frequency.CompareTo(mostPowerful.Frequency);
                if (result  > 0)
                    {
                    mostPowerful = cpu;
                    }
                }
            return mostPowerful;
            }

        public CPU GetCPU(string brand)
            {
            foreach (CPU cpu in Multiprocessor)
                {
                if (cpu.Brand == brand)
                    {
                    return cpu;
                    }
                }
            return null;
            }
        public string Report()
            {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (CPU cpu in Multiprocessor)
                {
                sb.AppendLine(cpu.ToString());
                }
            return sb.ToString().Trim();
            }
        }
    }
