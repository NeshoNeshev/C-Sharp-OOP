using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Data
    {
        private List<Person> persons;
        private List<Product> products;
        public Data()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }

        public IReadOnlyCollection<Person> Persons => this.persons.AsReadOnly();
        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();
        public void Run()
        {
            AddPersons();
            AddProducts();
            string command;
            while ((command=Console.ReadLine())!="END")
            {
                var commArg = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string personName = commArg[0];
                string productName = commArg[1];
                try
                {
                    Person person = this.persons.First(n => n.Name == personName);
                    Product product = this.products.First(p=>p.Name==productName);
                    person.BuyProduct(product);
                }
                catch (ArgumentException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }
            }
            foreach (Person person in this.persons)
            {
                Console.WriteLine(person);
            }

        }
        private void AddProducts()
        {
            var productArg = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < productArg.Length; i++)
            {
               
                var productAndCost = productArg[i].Split('=',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = productAndCost[0];
                decimal cost = decimal.Parse(productAndCost[1]);
                Product produkt = new Product(name, cost);
                this.products.Add(produkt);
            }

        }
       
        private void AddPersons()
        {
            var peopleArg = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < peopleArg.Length; i++)
            {
                //Pesho=11;Gosho=4
                var nameAndMoney = peopleArg[i].Split('=').ToArray();
                string name = nameAndMoney[0];
                decimal money = decimal.Parse(nameAndMoney[1]);
                Person person = new Person(name,money);
                this.persons.Add(person);
            }


        }
    }
}
