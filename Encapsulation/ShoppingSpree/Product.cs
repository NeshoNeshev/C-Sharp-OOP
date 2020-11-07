using System;


namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    
                    throw new ArgumentException(Comon.nameExeption);
                }
                this.name = value;

            }
        }


        public decimal Cost
        {

            get { return cost; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Comon.moneyExeption);
                }
                this.cost = value;

            }
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
