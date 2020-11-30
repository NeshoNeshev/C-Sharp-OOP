using System;
using SolidExersize.PrototypePattern;

namespace SolidExersize
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Drink("Coke");
            Sandwich sandwich = new Sandwich("saa", "sss", "sdsd", "dssas", drink);
            Sandwich sandwich2 = sandwich.ShallowCopy();
            Sandwich sandwich3 = sandwich.DeapCopy();

            Console.WriteLine("Original object: " + sandwich);
            Console.WriteLine("ShallowCopy object: " + sandwich2);
            Console.WriteLine("DeapCopy object: " + sandwich3);

            sandwich.Bread = "123";
            sandwich.Meat = "123";
            sandwich.Veggies = "123";
            sandwich.Cheese = "123";
            sandwich.Drinkrink.Name = "Test";

            Console.WriteLine("Original object: " + sandwich);
            Console.WriteLine("ShallowCopy object: " + sandwich2);
            Console.WriteLine("DeapCopy object: " + sandwich3);
        }
    }
}
