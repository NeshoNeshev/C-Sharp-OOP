﻿
namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age,string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
            this.Id = id;
        }
        public string Name { get; set; }

        public int Age { get; set; }
        public string Birthdate { get; private set; }

        public string Id { get; private set; }
    }
}
