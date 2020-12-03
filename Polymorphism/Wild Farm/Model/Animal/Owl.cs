using System;
using System.Collections.Generic;
using WildFarm.Model.Foods;

namespace WildFarm.Model.Animal
{
    public class Owl : Bird
    {
        public const double WEIGHT_MULTIPLAYER = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override ICollection<Type> preferentFood => new List<Type> { typeof(Meat) };

        public override double WeightMultiplier => WEIGHT_MULTIPLAYER;

        public override string ProducingSound()
        {
            return $"Hoot Hoot";
        }
        
    }
}
