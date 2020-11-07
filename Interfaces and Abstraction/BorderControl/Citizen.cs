
namespace BorderControl
{
    public class Citizen : IIdentifable
    {
        public Citizen(string name,int age, string id)
        {
            this.Age = age;
            this.Id = id;
            this.Name = name;
        }
        public int Age { get;private set; }
        public string Name { get;private set ; }
        public string Id { get;private set; }
    }
}
