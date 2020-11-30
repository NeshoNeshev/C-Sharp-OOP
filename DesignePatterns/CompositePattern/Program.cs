using System;

namespace CompositePattern
{
    public  class Program
    {
        static void Main(string[] args)
        {
           var singleGift = new SingleGift("test",10);
           Console.WriteLine(singleGift.CalculateTotalPrice());

           var compositeGifts = new Composite("Nesho",20);
           var singleGift2 = new SingleGift("WOW",50);
           var singleGift3= new SingleGift("WOW1", 80);
            compositeGifts.Add(singleGift2);
            compositeGifts.Add(singleGift3);
            Console.WriteLine(compositeGifts.CalculateTotalPrice());
        }
    }
}
