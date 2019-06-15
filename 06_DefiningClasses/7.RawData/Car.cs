using System;
using System.Collections.Generic;
using System.Text;

namespace _7.RawData
{
    public class Car
    {
        public string Model;

        public Engine Engine;

        public Cargo Cargo;

        public List<Tyre> Tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tyre> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
    }
}
