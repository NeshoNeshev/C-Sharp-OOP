using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Core.Contracts;
using WildFarm.Factories;
using WildFarm.Model;
using WildFarm.Model.Animal;
using WildFarm.Model.Animal.Contracts;
using WildFarm.Model.Foods;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<IAnimal> animals;
        private Factory factory;
        public Engine()
        {
            this.animals = new List<IAnimal>();
            this.factory = new Factory();
        }
        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var foodArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                IAnimal animal = CreateAnimal(animalArg);
                IFood food = this.factory.ProduceFood(foodArg[0], int.Parse(foodArg[1]));
                animals.Add(animal);
                Console.WriteLine(animal.ProducingSound());
                try
                {
                    animal.Feed(food);
                    
                }
                catch (InvalidPreferedFoodException msg)
                {

                    Console.WriteLine(msg.Message);
                    continue;
                }
                
            }
            foreach (IAnimal animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IAnimal CreateAnimal(string[] animalArg)
        {
            IAnimal animal = null;

            string type = animalArg[0];
            string name = animalArg[1];
            double weight = double.Parse(animalArg[2]);

            if (type == "Owl")
            {
                double wingSize = double.Parse(animalArg[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(animalArg[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else
            {
                string livingRegion = animalArg[3];
                if (type == "Dog")
                {
                    animal = new Dog(name, weight, livingRegion);
                }
                else if (type == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                //•	Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}"
                else
                {
                    string bread = animalArg[4];
                    if (type == "Cat")
                    {
                        animal = new Cat(name, weight, livingRegion, bread);
                    }
                    else if (type == "Tiger")
                    {
                        animal = new Tiger(name, weight, livingRegion, bread);
                    }
                }
            }
            return animal;
        }
    }
}
