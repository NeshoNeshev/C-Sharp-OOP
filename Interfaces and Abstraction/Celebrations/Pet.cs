
namespace BirthdayCelebrations
{
    public class Pet : ICharacteristics
    {
        public Pet(string name,string birthdate)
        {
            this.Birthdate = birthdate;
            this.Name = name;
        }
        public string Name { get;private set; }

        public string Birthdate { get; private set; }
    }
}
