using System;
using System.Collections.Generic;
using System.Text;

namespace _6.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TravelledDistance { get; set; }


        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            if (this.FuelAmount < distance * this.FuelConsumptionPerKm)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= distance * this.FuelConsumptionPerKm;
                this.TravelledDistance += distance;
            }
        }
    }

}
