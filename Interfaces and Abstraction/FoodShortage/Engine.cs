using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class Engine
    {
        private int sum;
        private List<IBuyer> buyers;
        public Engine()
        {
            this.buyers = new List<IBuyer>();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (input.Length==3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];
                    Rebel rebel = new Rebel(name,age,group);
                    buyers.Add(rebel);
                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];
                    Citizen citizen = new Citizen(name,age,id,birthdate);
                    buyers.Add(citizen);
                }
            }
            while (true)
            {
                string name = Console.ReadLine();
                if (name=="End")
                {
                    break;
                }
                var exist = buyers.Where(x => x.Name == name).FirstOrDefault();
                if (exist!=null)
                {
                    exist.BuyFood();
                }
                else
                {
                    continue;
                }
            }
            foreach (var item in buyers)
            {
                sum += item.Food;
            }
            Console.WriteLine(sum);
        }
        
    }
}
