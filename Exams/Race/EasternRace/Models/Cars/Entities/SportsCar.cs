
using System;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
     public class SportsCar:Car
    {
        private const double CUBIC_CENTIMETERS = 3000;
        private const int MIN_HORSE_POWER = 250;
        private const int MAX_HORSE_POWER = 450;
        private int horsePower;
        public SportsCar(string model, int horsePower)
            : base(model, horsePower)
        {
        }

        public override int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            protected set
            {
                if (value < MIN_HORSE_POWER || value > MAX_HORSE_POWER)
                {
                    string msg = string.Format(ExceptionMessages.InvalidHorsePower, value);
                    throw new ArgumentException(msg);
                }

                this.horsePower = value;
            }
        }

        public override double CubicCentimeters => CUBIC_CENTIMETERS;
    }
}
