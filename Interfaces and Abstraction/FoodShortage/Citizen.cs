using System;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        
        public Citizen(string name,int age,string id,string birthdate)
        {
            this.Food = 0;
            this.Name = name; ;
            this.Id = id;
            this.Age = age;
            this.Birthdate = birthdate;
        }
        public int Food { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
