using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
    {
    public class Car
        {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tyre[] tyre;
        public Car()
            {
            }
        public Car(string model, Engine engine, Cargo cargo, Tyre[] tyre): this ()
            {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tyre = tyre;
            }

        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Cargo Cargo { get { return cargo; } set { cargo = value; } }
        public Tyre[] Tyre { get { return tyre; } set { tyre = value; } }
        }
    }
