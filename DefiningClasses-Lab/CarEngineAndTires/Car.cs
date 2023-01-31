using CarManufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
    {
    internal class Car
        {
        //fields
        //shortcut for field + constructor - propfull
        private string make;
        private string model;
        private int year;
        private double fuelConsumption;
        private double fuelQuantity;

        //call different Classes
        private Engine engine;
        private Tire[] tires;


        //constructors 
        //shortCut - ctor
        public Car()
            {
            Make = "VW ";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
            }
        public Car(string make, string model, int year) : this()
            {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
            {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
            {
            Engine = engine;
            Tires = tires;
            }



        //properties
        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }
        //from other classes
        public Tire[] Tires { get { return tires; } set { tires = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }


        //methods
        public void Drive(double distance)
            {
            double neededFuel = distance * fuelConsumption;

            if (neededFuel < fuelQuantity)
                {
                fuelQuantity -= neededFuel;
                }
            else
                {
                Console.WriteLine("Not enough fuel to perform this trip!");
                }
            }
        public string WhoAmI()
            {
            string output = $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:f2} ";
            return output;
            }
        }
    }


