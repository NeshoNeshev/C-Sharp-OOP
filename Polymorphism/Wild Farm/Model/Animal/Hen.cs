using System;
using System.Collections.Generic;
using WildFarm.Model.Foods;

namespace WildFarm.Model.Animal
{
    public class Hen : Bird
    {
        public  const double WEIGHT_MULTIPLAYER = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {

        }

        public override ICollection<Type> preferentFood =>
            new List<Type>() {typeof(Vegetable),typeof(Fruit),typeof(Meat),typeof(Seeds) };

        public override double WeightMultiplier => WEIGHT_MULTIPLAYER;

        public override string ProducingSound()
        {
            return $"Cluck";
        }
        
    }
}
