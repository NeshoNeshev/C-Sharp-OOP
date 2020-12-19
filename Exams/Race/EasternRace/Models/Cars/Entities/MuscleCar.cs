
using System;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        private const double CUBIC_CENTIMETERS = 5000;
        private const int MIN_HORSE_POWER = 400;
        private const int MAX_HORSE_POWER = 600;
        private int horsePower;
        public MuscleCar(string model, int horsePower) 
            : base(model, horsePower )
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
