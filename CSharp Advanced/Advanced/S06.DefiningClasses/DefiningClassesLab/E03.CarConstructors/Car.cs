﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            Make = "VW";
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
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            set
            {
                fuelConsumption = value;
            }
        }

        public void Drive(double distance)
        {
            double neededFuel = fuelConsumption * distance;
            if (fuelQuantity - neededFuel <= 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }

            fuelQuantity -= neededFuel;
        }

        public string WhoAmI()
        {
            StringBuilder me = new StringBuilder();

            me.AppendLine($"Make: {this.make}");
            me.AppendLine($"Model: {this.model}");
            me.AppendLine($"Year: {this.year}");
            me.AppendLine($"Fuel: {this.fuelQuantity:f2}");

            return me.ToString();
        }
    }
}
