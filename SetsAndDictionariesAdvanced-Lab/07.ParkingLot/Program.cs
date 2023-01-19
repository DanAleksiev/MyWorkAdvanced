using System;
using System.Collections.Generic;

namespace _07.ParkingLot
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input;
            HashSet<string> carsInTheParkicing = new HashSet<string>();
            while ((input = Console.ReadLine()) != "END")
                {
                string[] traffic = input.Split(", ");
                string inOrOut = traffic[0];
                string car = traffic[1];

                if (inOrOut == "IN")
                    {
                    carsInTheParkicing.Add(car);
                    }
                else if (inOrOut == "OUT")
                    {
                    carsInTheParkicing.Remove(car);
                    }
                }

            if (carsInTheParkicing.Count > 0)
                {
                foreach (var car in carsInTheParkicing)
                    {
                    Console.WriteLine(car);
                    }
                }
            else
                {
                Console.WriteLine("Parking Lot is Empty");
                }
            }
        }
    }
