
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class Engine
    {
        private List<ICharacteristics> citizenAndPets;
        private List<Robot> robots;
        public Engine()
        {
            this.citizenAndPets = new List<ICharacteristics>();
            this.robots = new List<Robot>();
        }
        public void Run()
        {
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                string model = input[0];
                if (model == "Citizen")
                {
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    string id = input[3];
                    string bd = input[4];
                    Citizen citizen = new Citizen(name, bd, id, age);
                    citizenAndPets.Add(citizen);
                }
                else if (model == "Pet")
                {
                    string name = input[1];
                    string bd = input[2];
                    Pet pet = new Pet(name, bd);
                    citizenAndPets.Add(pet);
                }
                else if (model == "Robot")
                {
                    string name = input[1];
                    string id = input[2];
                    Robot robot = new Robot(name, id);
                    robots.Add(robot);
                }
            }
            string date = Console.ReadLine();           
            foreach (var item in citizenAndPets)
            {
                var index = item.Birthdate.TakeLast(date.Length).ToList();
                if (string.Join("", index) == date)
                {                  
                    Console.WriteLine($"{item.Birthdate}");
                }
            }        
        }
    }
}
