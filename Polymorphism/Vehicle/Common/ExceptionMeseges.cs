﻿using System;

namespace Vehicles.Common
{
    public class ExceptionMeseges : Exception
    {
        public const string NotEnoughtFuel = "{0} needs refueling";
        public const string NegFuel = "Fuel must be a positive number";
        public const string InvalidVehicleType = "Invalid vehicle type";
    }
}
