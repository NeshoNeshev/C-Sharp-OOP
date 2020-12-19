
using System;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public abstract class Car : ICar
    {
        private string _model;
        private int horsePower;
       
        public Car(string model, int horsePower)
        {
            this.Model = model;
            this.HorsePower = horsePower;
           
        }

        public virtual int MinHorsePower { get;private set; }
        public virtual int MaxHorsePower { get; private set; }
        public string Model
        {
            get
            {
                return this._model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel,value, 4));
                }

                this._model = value;
            }
        }

        public abstract int HorsePower { get; protected set; }


        public abstract double CubicCentimeters { get;}
        public double CalculateRacePoints(int laps)
        {
            double result = (this.CubicCentimeters / this.HorsePower) * laps;
            return result;
        }
    }
}
