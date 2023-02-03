using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
    {
    public class Car
        {
        private string model;
        private Engine engine;
        private int weight;
        private string colour;
        public Car()
            {
            weight= 0;
            Colour = "n/a";
            }
        public Car(string model, Engine engine, int weight, string colour) : this()
            {
            Model = model;
            Engine = engine;
            Weight = weight;
            Colour = colour;
            }

        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        }
    }
