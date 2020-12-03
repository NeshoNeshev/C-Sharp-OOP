using System;
using System.Collections.Generic;
using WildFarm.Model.Foods;

namespace WildFarm.Model.Animal
{
    public class Dog : Mammal
    {
        public const double WEIGHT_MULTIPLAYER = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override ICollection<Type> preferentFood => new List<Type>() { typeof(Meat) };

        public override double WeightMultiplier => WEIGHT_MULTIPLAYER;

        public override string ProducingSound()
        {
            return $"Woof!";
        }
        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
