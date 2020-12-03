namespace WildFarm.Model.Foods
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quanttity = quantity;
        }
        public int Quanttity { get; private set; }
    }
}
