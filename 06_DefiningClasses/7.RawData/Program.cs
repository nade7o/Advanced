using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} " +
                //    "{tire1Pressure} {tire1Age} " +
                //    "{tire2Pressure} {tire2Age} " +
                //    "{tire3Pressure} {tire3Age} " +
                //    "{tire4Pressure} {tire4Age}"
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                cars[i] = new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoType, cargoWeight),
                    new List<Tyre> { new Tyre(tire1Age, tire1Pressure), new Tyre(tire2Age, tire2Pressure), new Tyre(tire3Age, tire3Pressure), new Tyre(tire4Age, tire4Pressure)});
            }
            string command = Console.ReadLine();

            //"fragile" - print all cars whose cargo is "fragile" with a tire, whose pressure is  < 1
            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile")
                    .Where(c => c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model).ToList().ForEach(m => Console.WriteLine(m));
            }
           //"flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250
            if (command == "flamable")
            {
                cars.Where(c => c.Cargo.Type == "flamable")
                    .Where(c => c.Engine.Power > 250).Select(c => c.Model).ToList().ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
