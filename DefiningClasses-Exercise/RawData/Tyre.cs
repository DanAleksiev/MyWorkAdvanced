using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
    {
    public class Tyre
        {
        private double presure;
        private int age;
        public Tyre(int age, double pressure)
            {
            Age = age;
            Presure = pressure;
            }
        public double Presure { get { return presure; } set { presure = value; } }
        public int Age { get { return age; } set { age = value; } }

        }
    }
