
namespace CompositePattern
{
    public abstract class GiftBaseClass
    {
        public GiftBaseClass(string name,int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public int Price { get; set; }
        public string Name { get; set; }

        public abstract int CalculateTotalPrice();
    }
}
