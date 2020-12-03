using System;
using Vehicles.Common;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDriveble, IRefuelable
    {
        private const string SUCC_DRIVED_MSG = "{0} travelled {1} km";
        protected Vehicle(double fuelQuantity, double fuelConsumtion)
        {
            this.FuelConsumption = fuelConsumtion;
            this.FuelQuantity = fuelQuantity;
        }
        public double FuelQuantity { get; private set; }
        public virtual double FuelConsumption { get; }

        public string Drive(double amoount)
        {
            double fuelNeeded = amoount * this.FuelConsumption;
            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException
                    (String.Format(ExceptionMeseges.NotEnoughtFuel, this.GetType().Name));
            }
            this.FuelQuantity -= fuelNeeded;
            return String.Format(SUCC_DRIVED_MSG, this.GetType().Name, amoount);
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException(ExceptionMeseges.NegFuel);
            }
            this.FuelQuantity += amount;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
