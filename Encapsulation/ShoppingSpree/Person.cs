using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product>produkts;
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.produkts = new List<Product>();
        }
        public IReadOnlyCollection<Product> Produkts => this.produkts.AsReadOnly();

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

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Comon.moneyExeption);
                }
                this.money = value;

            }
        }
        public  void BuyProduct(Product product)
        {
            
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.produkts.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                throw new ArgumentException(String.Format(Comon.cantAfort,this.Name,product.Name));
            }
        }
        public override string ToString()
        {
            string output = this.produkts.Count > 0 ?
                String.Join(", ",this.produkts) : "Nothing bought";
            return $"{this.Name} - {output}";
        }

    }
}
