using System;
using System.Collections.Generic;
using WildFarm.Model.Foods;

namespace WildFarm.Model
{
    public class Tiger : Feline
    {
        public const double WEIGHT_MULTIPLAYER = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }
        public override ICollection<Type> preferentFood => new List<Type>() { typeof(Meat) };

        public override double WeightMultiplier => WEIGHT_MULTIPLAYER;

        public override string ProducingSound()
        {
            return $"ROAR!!!";
        }
    }
}
