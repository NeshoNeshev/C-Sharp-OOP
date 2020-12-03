using WildFarm.Model.Foods;

namespace WildFarm.Model.Animal.Contracts
{
    public interface IAnimal
    {
        
        public string Name { get;}
        public double Weight { get;}
        public int FoodEaten { get;}
        public string ProducingSound();
        void Feed(IFood food);
    }
}
