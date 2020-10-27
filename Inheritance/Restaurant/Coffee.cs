

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double coffeeMilliliters = 50;
        private const decimal coffeePrice = 3.50m;
        public Coffee(string name, double cafeine) : base(name, coffeePrice, coffeeMilliliters)
        {
            this.Caffeine = cafeine;
        }
        public double Caffeine { get; }
    }
}
