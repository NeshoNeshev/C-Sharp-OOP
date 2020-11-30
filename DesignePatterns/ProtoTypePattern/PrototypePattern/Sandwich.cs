
using System;
using System.Buffers;
using SolidExersize.PrototypePattern;

namespace SolidExersize
{
    public class Sandwich:SandwichPrototype<Sandwich>
    {
        public Sandwich(string bread,string meat,string cheese,string veggies,Drink drink)
        {
            this.Bread = bread;
            this.Meat = meat;
            this.Cheese = cheese;
            this.Veggies = veggies;
            this.Drinkrink = drink;
        }

        public Drink Drinkrink  { get; set; }

        public string Bread { get; set; }

        public string Meat { get; set; }

        public string Cheese { get; set; }

        public string Veggies { get; set; }
        //private string GetIngredientList()
        //{
        //    return $"{this.bread}, {this.meat}, {this.cheese}, {this.veggies}";
        //}

        public override string ToString()
        {
            return $"{Bread} {Cheese} {Meat} {Veggies} - {Drinkrink.Name}";
        }

        public override Sandwich ShallowCopy()
        {
            return this.MemberwiseClone() as Sandwich;
            
        }

        public override Sandwich DeapCopy()
        {
            var sandwich =this.MemberwiseClone() as Sandwich;
            sandwich.Bread= new string(this.Bread);
            sandwich.Cheese = new string(this.Cheese);
            sandwich.Meat = new string(this.Meat);
            sandwich.Veggies = new string(this.Veggies);

            sandwich.Drinkrink = new Drink(this.Drinkrink.Name);

            return sandwich;
        }
    }
}
