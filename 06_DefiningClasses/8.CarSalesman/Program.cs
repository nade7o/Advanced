using System;
using System.Collections.Generic;

namespace _8.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            //"{model} {power} {displacement} {efficiency}" - last two are optional
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                string power = engineInfo[1];

                if (engineInfo.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                else if (engineInfo.Length == 3)
                {
                    int displacement;
                    bool isDisplacement = int.TryParse(engineInfo[2], out displacement);
                    if (isDisplacement)
                    {
                        engines.Add(new Engine(model, power, displacement));
                    }
                    else
                    {
                        string efficiency = engineInfo[2];
                        engines.Add(new Engine(model, power, efficiency));
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            //"{model} {engine} {weight} {color}" - last two are optional
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                string engineModel = carInfo[1];
                Engine engine = new Engine(null, null);

                foreach (Engine eng in engines)
                {
                    if (eng.Model == engineModel)
                    {
                        engine = eng;
                    }
                }

                if (carInfo.Length == 2)
                {
                    cars.Add(new Car(model, engine));
                }
                else if (carInfo.Length == 3)
                {
                    int weight;
                    bool isWeight = int.TryParse(carInfo[2], out weight);
                    if (isWeight)
                    {
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        string color = carInfo[2];
                        cars.Add(new Car(model, engine, color));
                    }
                }
                else if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    cars.Add(new Car(model, engine, weight, color));
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency == null)
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }

                if (car.Weight == 0)
                {
                    Console.WriteLine(" Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                if (car.Color == null)
                {
                    Console.WriteLine("  Color: n/a");
                }
                else
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
              
            }
        }
    }
}
