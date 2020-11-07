
namespace FoodShortage
{
    interface IBuyer
    {
        public string Name { get; set; }
        public int Food { get;  }
        public void BuyFood();
    }
}
