
namespace BirthdayCelebrations
{
    public class Citizen : IIdentifiable, ICharacteristics
    {
        public Citizen(string name,string birthdate,string id ,int age)
        {
            this.Birthdate = birthdate;
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }
        public int Age { get;private set; }
    }
}
