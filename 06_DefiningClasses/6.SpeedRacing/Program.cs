using System;
using System.Linq;
namespace _6.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numberOfCars];


            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double KmAmount = double.Parse(carInfo[2]);
                cars[i] = new Car(model, fuelAmount, KmAmount);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandDrive = command.Split();
                string carModel = commandDrive[1];
                double distance = double.Parse(commandDrive[2]);

                cars.Where(c => c.Model == carModel).ToList().ForEach(c => c.Drive(distance));

            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
