using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Engine
    {

        private List<IIdentifable> citizenAndRobots;

        public Engine()
        {
            this.citizenAndRobots = new List<IIdentifable>();

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
                if (input.Length > 2)
                {

                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    Citizen citezen = new Citizen(name, age, id);
                    citizenAndRobots.Add(citezen);
                }
                else
                {
                    string name = input[0];
                    string id = input[1];
                    Robot robot = new Robot(name, id);
                    citizenAndRobots.Add(robot);
                }
            }
            string ind = Console.ReadLine() ;
            foreach (var item in citizenAndRobots)
            {
                var index = item.Id.TakeLast(ind.Length).ToList();
                if (string.Join("", index) == ind)
                {

                    Console.WriteLine($"{item.Id}");
                }
            }
        }
    }
}
