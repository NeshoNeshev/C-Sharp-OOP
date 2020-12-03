using System;
using System.Collections.Generic;
using WildFarm.Model.Foods;

namespace WildFarm.Model.Animal
{
    public class Mouse : Mammal
    {
        public const double WEIGHT_MULTIPLAYER = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override ICollection<Type> preferentFood => new List<Type>() { typeof(Vegetable), typeof(Fruit) };

        public override double WeightMultiplier => WEIGHT_MULTIPLAYER;

        public override string ProducingSound()
        {
            return $"Squeak";
        }
        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
