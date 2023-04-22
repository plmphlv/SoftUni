﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla:ICar,IElectricCar
    {
        private string model;
        private string color;
        private int battery;

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
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
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public int Battery
        {
            get
            {
                return battery;
            }

            set
            {
                battery = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Seat {Model} with {Battery} Batteries" +
                Environment.NewLine + Start() +
                Environment.NewLine + Stop();
        }
    }
}
