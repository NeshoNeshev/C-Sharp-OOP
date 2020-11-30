

using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Composite:GiftBaseClass,IGiftOperations
    {
        private ICollection<GiftBaseClass> giftBaseClasses;
        public Composite(string name, int price)
            : base(name, price)
        {
            this.giftBaseClasses = new List<GiftBaseClass>();
        }

        

        public void Add(GiftBaseClass giftBaseClass)
        {
           this.giftBaseClasses.Add(giftBaseClass);
        }

        public bool Remove(GiftBaseClass giftBaseClass)
        {
            return this.giftBaseClasses.Remove(giftBaseClass);
        }
        public override int CalculateTotalPrice()
        {
            var totalPrice = 0;

            foreach (var item in this.giftBaseClasses)
            {
                totalPrice += item.CalculateTotalPrice();
            }

            return totalPrice;
        }
    }
}
