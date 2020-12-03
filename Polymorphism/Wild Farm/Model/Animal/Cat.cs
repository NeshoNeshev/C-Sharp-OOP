﻿using System;
using System.Collections.Generic;
using WildFarm.Model.Foods;

namespace WildFarm.Model
{
    public class Cat : Feline
    {
        public const double WEIGHT_MULTIPLAYER = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        

        public override ICollection<Type> preferentFood => new List<Type>() { typeof(Vegetable), typeof(Meat) };

        public override double WeightMultiplier => WEIGHT_MULTIPLAYER;

        public override string ProducingSound()
        {
            return $"Meow";
        }
    }
}
