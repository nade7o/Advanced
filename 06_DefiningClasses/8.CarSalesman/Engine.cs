using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CarSalesman
{
   public class Engine
    {
        public string Model;

        public string Power;

        public int Displacement;

        public string Efficiency;

        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }

        public Engine(string model, string power, int displacement)
            :this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, string power, string efficiency)
            :this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, string power, int displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}
