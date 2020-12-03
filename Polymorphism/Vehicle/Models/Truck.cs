﻿namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCR = 1.6;
        private const double REFUEL_SUCC_COEFF = 0.95;

        public Truck(double fuelQuantity, double fuelConsumtion)
            : base(fuelQuantity, fuelConsumtion)
        {
        }
        public override double FuelConsumption =>
            base.FuelConsumption + FUEL_CONSUMPTION_INCR;
        public override void Refuel(double amount)
        {
            base.Refuel(amount * REFUEL_SUCC_COEFF);
        }

    }
}
