using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CarSalesman
{
   public class Car
    {
        public string Model;

        public Engine Engine;

        public double Weight;

        public string Color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, double weight)
            :this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            :this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, double weight, string color)
            :this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }
    }
}
