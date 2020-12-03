using System;
using System.Collections.Generic;
using WildFarm.Model.Animal.Contracts;
using WildFarm.Model.Foods;

namespace WildFarm.Model.Animal
{
    public abstract class Animal : IAnimal
    {
        public const string UneatenFood = "{0} does not eat {1}!";
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
           
        }
        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        public abstract ICollection<Type> preferentFood { get; }
        public abstract double WeightMultiplier { get; }
        public void Feed(IFood food)
        {
            if (!this.preferentFood.Contains(food.GetType()))
            {
                throw new InvalidPreferedFoodException(String.Format(UneatenFood, this.GetType().Name, food.GetType().Name));
            }
            this.Weight += this.WeightMultiplier * food.Quanttity;
            this.FoodEaten += food.Quanttity;
        }


        public abstract string ProducingSound();
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }

    }
}
