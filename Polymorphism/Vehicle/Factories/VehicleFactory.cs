using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models;

namespace Vehicles.Factories
{
    //Factory pattern

    public class VehicleFactory
    {
        public VehicleFactory()
        {

        }
        public Vehicle CreateVehicle(string vehicleType, double fuelQuantity, double fuelConsuption)
        {
            Vehicle vehicle;
            if (vehicleType=="Car")
            {
                vehicle = new Car(fuelQuantity,fuelConsuption);
            }
            else if (vehicleType=="Truck")
            {
                vehicle = new Truck(fuelQuantity,fuelConsuption);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMeseges.InvalidVehicleType);
            }
            return vehicle;
        }

    }
}
