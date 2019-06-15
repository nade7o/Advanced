using System;
using System.Collections.Generic;
using System.Text;

namespace _7.RawData
{
    public class Cargo
    {
        public string Type;

        public int Weight;

        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
    }
}
